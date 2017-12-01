using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tester
{
    public class Tester : ITester
    {
        public Tester(ICollectorTests collertor,IAlgorithmProcessTests algorithmProcessTests)
        {
            _algorithmProcessTests = algorithmProcessTests;
            _collector = collertor;
        }
        public void Run()
        {
            var tests = _collector.MakeTestBlocks();
            var resultTests = _algorithmProcessTests.StartTesting(tests);
        }


        private readonly IAlgorithmProcessTests _algorithmProcessTests;
        private readonly ICollectorTests _collector;
    }
}
