using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellTester
{
    public struct TestBlock
    {
        TestBlock(String input, String output)
        {
            inputFileName = input;
            idealOutputFileName = output;
        }
        String inputFileName;
        String idealOutputFileName;
    }
}
