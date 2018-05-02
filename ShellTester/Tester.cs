using System.Collections.Generic;

namespace ShellTester
{
	public class Tester : ITester
	{
		public Tester(ICollectorTests collertor, IProcessTestsLauncher processTestsLauncher)
		{
			_processTestsLauncher = processTestsLauncher;
			_collector = collertor;
		}

		public IEnumerable<TestResult> Run()
		{
			var tests = _collector.MakeTestBlocks();
			return _processTestsLauncher.StartTesting(tests);
		}

		private readonly IProcessTestsLauncher _processTestsLauncher;
		private readonly ICollectorTests _collector;
	}
}