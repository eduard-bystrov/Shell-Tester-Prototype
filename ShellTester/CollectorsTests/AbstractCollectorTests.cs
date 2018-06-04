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
		}

		public virtual IEnumerable<Test> MakeTestBlocks() => throw new NotImplementedException();


		private readonly IConfigTestsetProvider _defaultConfig = new DefaultConfigTestsetProvider();
		public virtual IConfigTestsetProvider Config { get => _defaultConfig; }

		protected readonly IPlatformLogger _logger;
		protected readonly String _workPath;
		protected TestFilePattern InputFilePattern => _configTestsetProvider.InputFilePattern;
		protected TestFilePattern OutputFilePattern => _configTestsetProvider.OuputFilePattern;
		protected readonly IConfigTestsetProvider _configTestsetProvider;

		
	}
}