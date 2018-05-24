using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellTester.Launchers
{
	public class WhileSuccessTestsLauncher : BaseTestsLauncher
	{
		public WhileSuccessTestsLauncher(IOneTestRunner oneTestRunner)
			: base(oneTestRunner)
		{

		}

		public override IEnumerable<TestResult> StartTesting(IEnumerable<Test> tests)
		{
			throw new NotImplementedException();
		}
	}
}
