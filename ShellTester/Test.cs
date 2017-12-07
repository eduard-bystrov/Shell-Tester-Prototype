using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellTester
{
    public struct Test
    {
        Test(String input, String output)
        {
            inputFileName = input;
            idealOutputFileName = output;
        }
        public String inputFileName;
        public String idealOutputFileName;
    }
}
