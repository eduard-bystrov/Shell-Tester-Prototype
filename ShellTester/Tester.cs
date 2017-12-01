using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShellTester
{
    public class Tester : ITester
    {
        Tester(IAlgorithmProcessTests algorithmProcessTests)
        {
            _algorithmProcessTests = algorithmProcessTests;
        }
        public void Run()
        {
            throw new NotImplementedException();
        }


        private readonly IAlgorithmProcessTests _algorithmProcessTests;
    }
}
