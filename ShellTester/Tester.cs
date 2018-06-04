using Logger;
using ShellTester.CollectorsTests;
using ShellTester.Launchers;
using System;
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
			_logger = logger ?? throw new NullReferenceException(nameof(IPlatformLogger));
			_collector = collertor ?? throw new NullReferenceException(nameof(ICollectorTests));
			_processTestsLauncher = processTestsLauncher ?? throw new NullReferenceException(nameof(IProcessTestsLauncher));
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