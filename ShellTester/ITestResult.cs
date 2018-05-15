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
		Int32 Id { get; }
		TestDescription Description { get; }
		TestResultType Type { get; }
		TimeSpan ExecutionTime { get; }
		Int64 PeekMemory { get; }
		String ToJson { get; }
	}
}
