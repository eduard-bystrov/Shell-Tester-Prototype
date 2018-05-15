using System;
using System.Diagnostics;
using System.IO;

namespace Logger
{
	/// <summary>
	///
	/// </summary>
	public class StreamLogger : IPlatformLogger, IDisposable
	{
		private LogPriority _minLevel = LogPriority.VeryLow;
		private readonly TextWriter _streamWriter;

		/// <summary>
		/// Определяет включен ли логгер
		/// </summary>
		public bool IsEnable { get; set; }

		/// <summary>
		/// Возвращает минимальную установленую категорию
		/// </summary>
		public LogPriority MinPriority
		{
			get { return _minLevel; }
			set { _minLevel = value; }
		}

		/// <summary>
		/// Конструктор
		/// </summary>
		public StreamLogger(TextWriter tw)
		{
			if (tw == null) throw new ArgumentNullException("tw");
			_streamWriter = tw;
			IsEnable = true;
		}

		public StreamLogger(TextWriter tw, LogPriority minLevel)
		{
			if (tw == null) throw new ArgumentNullException("tw");
			_streamWriter = tw;
			_minLevel = minLevel;
			IsEnable = true;
		}

		/// <summary>
		/// Записывает сообщение
		/// </summary>
		/// <param name="message">Сообщение</param>
		/// <param name="category">Категория сообщения</param>
		/// <param name="priority">Приоритет сообщения</param>
		public void Log(string message, LogCategory category, LogPriority priority)
		{
			Write(category, priority, false, message);
		}

		public void Write(LogCategory category, LogPriority priority, string message, params object[] args)
		{
			Write(category, priority, false, message, args);
		}

		public void Write(LogCategory category, LogPriority priority, bool system, string message, params object[] args)
		{
			if (!IsEnable)
			{
				return;
			}
			if (priority > _minLevel)
				return;

			string prefix = "";
			switch (category)
			{
				case LogCategory.Debug:
					prefix = "[DBG]";
					break;

				case LogCategory.Error:
					prefix = "[ERR]";
					break;

				case LogCategory.Info:
					prefix = "[INF]";
					break;

				case LogCategory.Warn:
					prefix = "[WRN]";
					break;
			}
			var logMessage = String.Format("[{0}] {1} {2}", DateTime.Now, prefix, String.Format(message, args));
			if (_streamWriter != null)
			{
				lock (_streamWriter)
				{
					_streamWriter.WriteLine(logMessage);
				}
			}
			else
			{
				Trace.WriteLine(logMessage);
			}
		}

		public void SetHdrString(string key, string msg)
		{
			Trace.WriteLine(msg);
		}

		public void Dispose()
		{
			lock (_streamWriter)
			{
				_streamWriter.Dispose();
			}
		}
	}
}