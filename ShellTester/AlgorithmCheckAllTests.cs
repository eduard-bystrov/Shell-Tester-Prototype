using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellTester
{
    public class AlgorithmCheckAllTests : IAlgorithmProcessTests
    {
       public AlgorithmCheckAllTests()
        {
            _runnerOneTest = new RunnerOneTest();
        }
        public ResultTest[] StartTesting(TestBlock[] tests)
        {
            var result = new List<ResultTest>();
            foreach(var test in tests)
            {
                result.Add(_runnerOneTest.Run(test));
            }

            return result.ToArray();
        }

        private readonly IRunnerOneTest _runnerOneTest;
    }
}
