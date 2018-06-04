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
		public AbstractCollectorTests(
			IPlatformLogger logger,
			IConfigTestsetProvider configProvider,
			String workPath
		)
		{
			_logger = logger;
			_configTestsetProvider = configProvider;
			_workPath = workPath;
		}

		public virtual IEnumerable<Test> MakeTestBlocks() => throw new NotImplementedException();
		public virtual IConfigTestsetProvider Config { get => throw new NotImplementedException(); }

		protected readonly IPlatformLogger _logger;
		protected readonly String _workPath;
		protected TestFilePattern InputFilePattern => _configTestsetProvider.InputFilePattern;
		protected TestFilePattern OutputFilePattern => _configTestsetProvider.OuputFilePattern;
		protected readonly IConfigTestsetProvider _configTestsetProvider;

		
	}
}