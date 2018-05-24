using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellTester.Launchers
{
	public class WhileSuccessTestsLauncher : AbstractTestsLauncher
	{
		public WhileSuccessTestsLauncher(IOneTestRunner oneTestRunner)
			: base(oneTestRunner)
		{

		}

		public override IEnumerable<TestResult> StartTesting(IEnumerable<Test> tests)
		{
			bool wasWrong = false;

			foreach (var test in tests)
			{
				if (wasWrong)
				{
					yield return new TestResult()
					{
						Id = test.Id,
						Kind = TestResultKind.NotLaunched
					};
				}
				else
				{
					var result = _oneTestRunner.Run(test);
					wasWrong = result.Kind != TestResultKind.Success;
					yield return result;
				}
			}
		}
	}
}
