using System.Collections.Generic;

namespace ShellTester
{
	public interface IProcessTestsLauncher
	{
		IEnumerable<TestResult> StartTesting(IEnumerable<Test> tests);
	}
}