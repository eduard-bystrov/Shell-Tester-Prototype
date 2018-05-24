using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellTester.Launchers
{
	abstract public class BaseTestsLauncher : IProcessTestsLauncher
	{
		public BaseTestsLauncher(IOneTestRunner oneTestRunner)
		{
			_oneTestRunner = oneTestRunner;
		}

		public virtual IEnumerable<TestResult> StartTesting(IEnumerable<Test> tests)
		{
			throw new NotImplementedException();
		}

		protected readonly IOneTestRunner _oneTestRunner;
	}
}
