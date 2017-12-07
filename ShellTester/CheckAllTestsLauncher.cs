using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellTester
{
    public class CheckAllTestsLauncher : IProcessTestsLauncher
    {
       public CheckAllTestsLauncher()
        {
            _runnerOneTest = new OneTestRunner();
        }
        public TestResult[] StartTesting(TestBlock[] tests)
        {
            var result = new List<TestResult>();
            foreach(var test in tests)
            {
                result.Add(_runnerOneTest.Run(test));
            }

            return result.ToArray();
        }

        private readonly IOneTestRunner _runnerOneTest;
    }
}
