using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellTester
{
	public enum TestResultKind
	{
		NotLaunched,
		Success,
		WrongAnswer,
		RuntimeError,
		CompilationError,
		TimeLimitExceeded,
		MemoryLimitExceeded,
		None,
	}
	public interface ITestResult
	{
		String Id { get; }
		TestDescription Description { get; }
		TestResultKind Kind { get; }
		TimeSpan ExecutionTime { get; }
		Int64 PeekMemory { get; }

		Int32 ExecutionTime_ms { get; }
		Int32 ExecutionTime_s { get; }
		Int32 ExecutionTime_m { get; }
	}
}
