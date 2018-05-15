using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Enhanced
{
	public static class LogLevelExtensions
	{
		private struct CatPrior
		{
			public CatPrior(LogCategory category, LogPriority priority)
				: this()
			{
				Category = category;
				Priority = priority;
			}

			public readonly LogCategory Category;
			public readonly LogPriority Priority;
		}

		private static CatPrior GetPriority(LogLevel level)
		{
			switch (level)
			{
				case LogLevel.InfoCritical:
					return new CatPrior(LogCategory.Info, LogPriority.Highest);
				case LogLevel.Fatal:
					return new CatPrior(LogCategory.Error, LogPriority.Highest);
				case LogLevel.Error:
					return new CatPrior(LogCategory.Error, LogPriority.VeryHigh);
				case LogLevel.Warn:
					return new CatPrior(LogCategory.Warn, LogPriority.High);
				case LogLevel.Info:
					return new CatPrior(LogCategory.Info, LogPriority.Medium);
				case LogLevel.Debug:
					return new CatPrior(LogCategory.Debug, LogPriority.Low);
				case LogLevel.Trace:
					return new CatPrior(LogCategory.Debug, LogPriority.VeryLow);
				case LogLevel.Ignore:
					return new CatPrior(LogCategory.Debug, (LogPriority)Byte.MaxValue);
				default:
					return new CatPrior(LogCategory.Info, LogPriority.Highest);
			}
		}

		public static Boolean CanLog(this IPlatformLogger logger, LogLevel level)
		{
			var cp = GetPriority(level);
			return cp.Priority <= logger.MinPriority;
		}

		public static void Write(this IPlatformLogger logger, LogLevel level, String message, params Object[] pars)
		{
			var cp = GetPriority(level);
			if (cp.Priority == (LogPriority)Byte.MaxValue) return;
			if (level == LogLevel.Fatal)
			{
				logger.Write(cp.Category, cp.Priority, true, message, pars);
			}
			else
			{
				logger.Write(cp.Category, cp.Priority, message, pars);
			}
		}

		public static void InfoCritical(this IPlatformLogger logger, String message, params Object[] pars)
		{
			Write(logger, LogLevel.InfoCritical, message, pars);
		}
		public static void Fatal(this IPlatformLogger logger, String message, params Object[] pars)
		{
			Write(logger, LogLevel.Fatal, message, pars);
		}
		public static void Error(this IPlatformLogger logger, String message, params Object[] pars)
		{
			Write(logger, LogLevel.Error, message, pars);
		}
		public static void Warn(this IPlatformLogger logger, String message, params Object[] pars)
		{
			Write(logger, LogLevel.Warn, message, pars);
		}
		public static void Info(this IPlatformLogger logger, String message, params Object[] pars)
		{
			Write(logger, LogLevel.Info, message, pars);
		}
		public static void Debug(this IPlatformLogger logger, String message, params Object[] pars)
		{
			Write(logger, LogLevel.Debug, message, pars);
		}
		public static void Trace(this IPlatformLogger logger, String message, params Object[] pars)
		{
			Write(logger, LogLevel.Trace, message, pars);
		}


	}
}
