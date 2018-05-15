using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Logger.Enhanced
{
	public class OperationScopeLogger : ScopeLogger, IDisposable
	{
		private readonly Stopwatch _stopwatch;
		private readonly LogMessage _headerMessage;

		public OperationScopeLogger OuterScope { get; }

		public OperationScopeLogger(
			IPlatformLogger logger,
			OperationScopeLogger outerScope,
			LogLevel logLevel,
			String operationName,
			LogMessage headerMessage
			) : base(logger, operationName, logLevel)
		{
			_stopwatch = new Stopwatch();
			_stopwatch.Start();
			OuterScope = outerScope;
			_headerMessage = headerMessage;
			WriteHeader();
		}

		private void WriteHeader()
		{
			if (_headerMessage.HasMessage)
			{
				Write("OP_Started. " + _headerMessage.Message, _headerMessage.Args);
			}
			else
			{
				Write("OP_Started");
			}
		}

		public override Boolean IncreaseLevel(LogLevel newLogLevel)
		{
			if (base.IncreaseLevel(newLogLevel))
			{
				if (_headerMessage.HasMessage)
				{
					Write($"OP_Continues from {_stopwatch.ElapsedMilliseconds} ms. " + _headerMessage.Message, _headerMessage.Args);
				}
				else
				{
					Write("OP_Continues from {0} ms", _stopwatch.ElapsedMilliseconds);
				}
				return true;
			}
			return false;
		}

		private struct CounterResult
		{
			public CounterResult(String name, Int64 elapsedMs, List<CounterResult> innerResults)
			{
				Name = name;
				ElapsedMs = elapsedMs;
				InnerResults = innerResults;
			}

			public String Name { get; }
			public Int64 ElapsedMs { get; }
			public List<CounterResult> InnerResults { get; }
		}

		private List<CounterResult> _innerOperationResults;

		private void AddInnerOperationResult(CounterResult result)
		{
			if (_innerOperationResults == null) _innerOperationResults = new List<CounterResult>();
			_innerOperationResults.Add(result);
		}

		private Boolean _isDisposed = false;

		public void Dispose()
		{
			if (_isDisposed) return;
			_isDisposed = true;
			_stopwatch.Stop();

			const String format = "OP_Finished in {0} ms";
			if (_innerOperationResults == null)
			{
				Write(format, _stopwatch.ElapsedMilliseconds);
			}
			else if (Source.CanLog(LogLevel))
			{
				var builder = new StringBuilder();
				builder.AppendFormat(format, _stopwatch.ElapsedMilliseconds);
				foreach (var inner in _innerOperationResults)
				{
					BuildMessage(inner, builder);
				}
			}

			if (OuterScope != null)
			{
				OuterScope.AddInnerOperationResult(new CounterResult(ScopePrefix, _stopwatch.ElapsedMilliseconds, _innerOperationResults));
			}
		}

		private static void BuildMessage(CounterResult result, StringBuilder builder, String prefix = "\t")
		{
			builder.AppendLine().Append(prefix).Append(result.Name).Append(": ").Append(result.ElapsedMs).Append(" ms");
			if (result.InnerResults == null) return;
			var nextPrefix = prefix + "\t";
			foreach (var inner in result.InnerResults)
			{
				BuildMessage(inner, builder, nextPrefix);
			}
		}
	}
}