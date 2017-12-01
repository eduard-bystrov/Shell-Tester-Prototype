using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ShellTester;

namespace ShellTesterPrototype
{
    class Program
    {
        static void Main(string[] args)
        {
            ITester tester = new Tester();
            tester.Run();
        }
    }
}
