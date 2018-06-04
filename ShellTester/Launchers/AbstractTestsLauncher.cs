using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellTester.Launchers
{
	abstract public class AbstractTestsLauncher : IProcessTestsLauncher
	{
		public AbstractTestsLauncher(IOneTestRunner oneTestRunner)
		{
			_oneTestRunner = oneTestRunner ?? throw new NullReferenceException(nameof(IOneTestRunner));
		}

		public virtual IEnumerable<TestResult> StartTesting(IEnumerable<Test> tests)
		{
			throw new NotImplementedException();
		}

		protected readonly IOneTestRunner _oneTestRunner;
	}
}
