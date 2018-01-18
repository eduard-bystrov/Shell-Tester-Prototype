using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellTester
{
    public struct Test
    {
        public Test(string input, string output)
        {
            inputFileName = input;
            idealOutputFileName = output;
        }
        public string inputFileName;
        public string idealOutputFileName;
    }
}
