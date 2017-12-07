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
		TestDescription Description { get; }
		TestResultType Type { get; }
		TimeSpan ExecutionTime { get; }
	}
}
