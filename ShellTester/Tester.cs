using Logger;
using System.Collections.Generic;

namespace ShellTester
{
	public class Tester : ITester
	{
		public Tester(
			IPlatformLogger logger,
			ICollectorTests collertor, 
			IProcessTestsLauncher processTestsLauncher
		)
		{
			_processTestsLauncher = processTestsLauncher;
			_collector = collertor;
			_logger = logger;
		}

		public IEnumerable<TestResult> Run()
		{
			var tests = _collector.MakeTestBlocks();
			return _processTestsLauncher.StartTesting(tests);
		}

		private readonly IProcessTestsLauncher _processTestsLauncher;
		private readonly ICollectorTests _collector;
		private readonly IPlatformLogger _logger;
	}
}