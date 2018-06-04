using Logger;
using ShellTester.ConfigProviders;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace ShellTester.CollectorsTests
{
	public abstract class AbstractCollectorTests : ICollectorTests
	{

		//TODO workPath check
		public AbstractCollectorTests(
			IPlatformLogger logger,
			String workPath
		)
		{
			_logger = logger ?? throw new NullReferenceException(nameof(IPlatformLogger));
			_workPath = workPath;
			_configTestsetProvider = new DefaultConfigTestsetProvider();
		}

		public virtual IEnumerable<Test> MakeTestBlocks() => throw new NotImplementedException();


		public virtual IConfigTestsetProvider Config { get => _configTestsetProvider; }

		protected readonly IPlatformLogger _logger;
		protected readonly String _workPath;
		protected TestFilePattern InputFilePattern => _configTestsetProvider.InputFilePattern;
		protected TestFilePattern OutputFilePattern => _configTestsetProvider.OuputFilePattern;
		protected readonly IConfigTestsetProvider _configTestsetProvider;
	}
}