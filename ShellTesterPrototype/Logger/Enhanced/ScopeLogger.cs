using System;

namespace Logger.Enhanced
{
	public class ScopeLogger : IPlatformLogger
	{
		public IPlatformLogger Source { get; }

		public ScopeLogger(
			IPlatformLogger logger,
			String scopePrefix,
			LogLevel logLevel
			)
		{
			Source = logger;
			ScopePrefix = scopePrefix;
			LogLevel = logLevel;
		}

		public String ScopePrefix { get; }

		public LogLevel LogLevel { get; private set; }

		public void Write(String message, params Object[] args)
		{
			this.Write(LogLevel, message, args);
		}

		public virtual Boolean IncreaseLevel(LogLevel newLogLevel)
		{
			Boolean needIncrease = newLogLevel < LogLevel;
			if (!needIncrease) return false;

			LogLevel = newLogLevel;
			return true;
		}

		public void Write(LogCategory category, LogPriority priority, String message, params Object[] args)
		{
			Source.Write(category, priority, ScopePrefix + message, args);
		}

		public void Write(LogCategory category, LogPriority priority, Boolean system, String message, params Object[] args)
		{
			Source.Write(category, priority, system, ScopePrefix + message, args);
		}

		public LogPriority MinPriority => Source.MinPriority;
		public Boolean IsEnable => Source.IsEnable;
	}
}