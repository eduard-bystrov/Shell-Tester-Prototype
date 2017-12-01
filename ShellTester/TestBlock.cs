using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester
{
    public struct TestBlock
    {
        TestBlock(String input, String output)
        {
            inputFileName = input;
            idealOutputFileName = output;
        }
        public String inputFileName;
        public String idealOutputFileName;
    }
}
