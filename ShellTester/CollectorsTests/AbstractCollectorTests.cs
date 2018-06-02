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
			IConfigTestsetSettings configProvider,
			String workPath,
			TestFilePattern inputFilePattern,
			TestFilePattern outputFilePatten
		)
		{
			_logger = logger;
			_configTestsetProvider = configProvider;
			_workPath = workPath;
			_inputFilePattern = inputFilePattern;
			_outputFilePattern = outputFilePatten;
		}

		public virtual IEnumerable<Test> MakeTestBlocks()
		{
			throw new NotImplementedException();
		}

		protected readonly IPlatformLogger _logger;
		protected readonly String _workPath;
		protected readonly TestFilePattern _inputFilePattern;
		protected readonly TestFilePattern _outputFilePattern;
		protected readonly IConfigTestsetSettings _configTestsetProvider;

	}
}