using System.Collections.Generic;

namespace ShellTester.Launchers
{
	public interface IProcessTestsLauncher
	{
		IEnumerable<TestResult> StartTesting(IEnumerable<Test> tests);
	}
}