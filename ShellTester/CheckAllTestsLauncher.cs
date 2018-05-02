using System.Collections.Generic;
using System.Linq;

namespace ShellTester
{
	public class CheckAllTestsLauncher : IProcessTestsLauncher
	{
		public CheckAllTestsLauncher(IOneTestRunner oneTestRunner)
		{
			_oneTestRunner = oneTestRunner;
		}

		public IEnumerable<TestResult> StartTesting(IEnumerable<Test> tests)
		{
			return tests.Select(x => { return _oneTestRunner.Run(x); });
		}

		private readonly IOneTestRunner _oneTestRunner;
	}
}