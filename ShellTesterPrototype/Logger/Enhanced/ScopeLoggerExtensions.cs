using System;

namespace Logger.Enhanced
{
	public static class OperationScopeLoggerExtensions
	{
		public static ScopeLogger MakeScope(this IPlatformLogger source, String scopePrefix, LogLevel logLevel = LogLevel.Info)
		{
			return new ScopeLogger(source, scopePrefix, logLevel);
		}

		public static OperationScopeLogger BeginOperation(this IPlatformLogger source, LogLevel logLevel, String operationName)
		{
			return new OperationScopeLogger(source, null, logLevel, operationName, new LogMessage());
		}

		public static OperationScopeLogger BeginOperation(this IPlatformLogger source, LogLevel logLevel, String operationName, String format, params Object[] args)
		{
			return new OperationScopeLogger(source, null, logLevel, operationName, new LogMessage(format, args));
		}

		public static OperationScopeLogger BeginInnerOperation(this OperationScopeLogger source, LogLevel logLevel, String operationName)
		{
			return new OperationScopeLogger(source, source, logLevel, operationName, new LogMessage());
		}

		public static OperationScopeLogger BeginInnerOperation(this OperationScopeLogger source, LogLevel logLevel, String operationName, String format, params Object[] args)
		{
			return new OperationScopeLogger(source, source, logLevel, operationName, new LogMessage(format, args));
		}
	}
}