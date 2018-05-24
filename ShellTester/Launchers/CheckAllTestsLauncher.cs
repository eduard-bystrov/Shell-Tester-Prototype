using System.Collections.Generic;
using System.Linq;

namespace ShellTester.Launchers
{
	public class CheckAllTestsLauncher : AbstractTestsLauncher
	{
		public CheckAllTestsLauncher(IOneTestRunner oneTestRunner)
			:base(oneTestRunner)
		{

		}

		public override IEnumerable<TestResult> StartTesting(IEnumerable<Test> tests)
		{
			return tests.Select(x => _oneTestRunner.Run(x));
		}

	}
}