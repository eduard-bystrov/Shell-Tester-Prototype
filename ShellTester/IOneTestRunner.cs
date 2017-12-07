using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellTester
{
    public interface IOneTestRunner
    {
        TestResult Run(TestBlock test);
    }
}
