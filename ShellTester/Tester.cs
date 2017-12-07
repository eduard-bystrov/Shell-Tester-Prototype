using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShellTester
{
    public class Tester : ITester
    {
        public Tester(ICollectorTests collertor,IProcessTestsLauncher processTestsLauncher)
        {
			_processTestsLauncher = processTestsLauncher;
            _collector = collertor;
        }
        public void Run()
        {
            var tests = _collector.MakeTestBlocks();
            var resultTests = _processTestsLauncher.StartTesting(tests);
        }


        private readonly IProcessTestsLauncher _processTestsLauncher;
        private readonly ICollectorTests _collector;
    }
}
