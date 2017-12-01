using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester
{
    public interface IAlgorithmProcessTests
    {
        ResultTest[] StartTesting(TestBlock[] tests);
    }
}
