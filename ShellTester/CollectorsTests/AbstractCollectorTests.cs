using Logger;
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
			String workPath,
			TestFilePattern inputFilePattern,
			TestFilePattern outputFilePatten
		)
		{
			_logger = logger;
			_workPath = workPath;
			_inputFilePattern = inputFilePattern;
			_outputFilePattern = outputFilePatten;
		}

		public virtual IEnumerable<Test> MakeTestBlocks()
		{
			throw new NotImplementedException();
		}


		//private string[] GetArrayOfNumberTest(string[] filesname, TestFilePattern pattern)
		//{
		//	var result = from filename in filesname
		//				 select GetNumberOfTestFileName(filename, pattern)
		//				 .ToArray().ToString();
		//	return result;
		//}

		protected readonly IPlatformLogger _logger;
		protected readonly String _workPath;
		protected readonly TestFilePattern _inputFilePattern;
		protected readonly TestFilePattern _outputFilePattern;

		// может быть разбить на три блока и потом собирать их ?
		// парсить в один блок потом разбивать ?
		// что если два файла с одинаковым номером
		// что будет если преф. и/или суф. пустые
		// перемудрил, мб, вернуть как было )00000
	}
}