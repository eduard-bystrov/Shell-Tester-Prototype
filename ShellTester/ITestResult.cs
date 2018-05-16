using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellTester
{
	public enum TestResultType
	{
		NotLaunched,
		Success,
		WrongAnswer,
		RuntimeError,
		CompilationError,
		TimeLimitExceeded,
		MemoryLimitExceeded
	}
	public interface ITestResult
	{
		String Id { get; }
		TestDescription Description { get; }
		TestResultType Type { get; }
		TimeSpan ExecutionTime { get; }
		Int64 PeekMemory { get; }
		String ToJson { get; }

		Int32 ExecutionTime_ms { get; }
		Int32 ExecutionTime_s { get; }
		Int32 ExecutionTime_m { get; }
	}
}
