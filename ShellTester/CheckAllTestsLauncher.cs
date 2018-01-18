using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellTester
{
    public class CheckAllTestsLauncher : IProcessTestsLauncher
    {
       public CheckAllTestsLauncher(IOneTestRunner oneTestRunner)
        {
			_oneTestRunner = oneTestRunner;
        }
        public TestResult[] StartTesting(Test[] tests)
        {
            var result = new List<TestResult>();
            foreach(var test in tests)
            {
                result.Add(_oneTestRunner.Run(test));
            }
			
            return result.ToArray();
        }

        private readonly IOneTestRunner _oneTestRunner;
    }
}
