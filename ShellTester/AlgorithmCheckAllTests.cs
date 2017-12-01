using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester
{
    public class AlgorithmCheckAllTests : IAlgorithmProcessTests
    {
       public AlgorithmCheckAllTests()
        {
            _runnerOneTest = new SimpleRunOneTest();
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

        private readonly ISimpleRunOneTest _runnerOneTest;
    }
}
