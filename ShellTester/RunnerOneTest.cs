using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester
{
    class RunnerOneTest : IRunnerOneTest
    {
        public ResultTest Run(TestBlock test)
        {
            return new ResultTest();
        }
    }
}
