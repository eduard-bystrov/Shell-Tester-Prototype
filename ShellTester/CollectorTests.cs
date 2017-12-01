using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellTester
{
    public class CollectorTests : ICollectorTests
    {
        public TestBlock[] MakeTestBlocks()
        {
            TestBlock[] res = new TestBlock[4];

            for (int i = 1; i <= 4; ++i)
            {
                res[i - 1].inputFileName = String.Format("{0}_IN", i);
                res[i - 1].idealOutputFileName = String.Format("{0}_OUT", i);
            }
            
            return res;
        }
    }
}
