using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester
{
    public interface ISimpleRunOneTest
    {
        ResultTest Run(TestBlock test);
    }
}
