using System;

namespace Logger.Enhanced
{
	public enum LogLevel
	{
		InfoCritical = 0,
		Fatal = 1,
		Error = 2,
		Warn = 3,
		Info = 4,
		Debug = 5,
		Trace = 6,
		Ignore = Int32.MaxValue,
	}
}