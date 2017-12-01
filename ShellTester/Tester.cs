using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShellTester
{
    public class Tester : ITester
    {
        Tester(ICollectorTests collertor,IAlgorithmProcessTests algorithmProcessTests)
        {
            _algorithmProcessTests = algorithmProcessTests;
            _collector = collertor;
        }
        public void Run()
        {
            throw new NotImplementedException();
        }


        private readonly IAlgorithmProcessTests _algorithmProcessTests;
        private readonly ICollectorTests _collector;
    }
}
