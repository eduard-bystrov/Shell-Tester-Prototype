using Logger;
using System;
using System.IO;
using System.Linq;

namespace ShellTester.CreatorsTestset
{
	public class TestsetCreator : ITestsetCreator
	{
		public TestsetCreator(
			ITestOutputDataCreator creator,
			IPlatformLogger logger,
			String workPath,
			TestFilePattern inputFilePattern,
			TestFilePattern outputFilePatten
		)
		{
			_creator = creator;
			_logger = logger;
			_workPath = workPath;
			_inputFilePattern = inputFilePattern;
			_outputFilePattern = outputFilePatten;
		}

		public void Create()
		{
			var inputFiles = Directory.GetFiles(_workPath)
							.Where(file => _inputFilePattern.GetFullRegex().IsMatch(file));

			foreach (var inputFile in inputFiles)
			{
				var result = _creator.Create(new StreamReader(inputFile));
				result.BaseStream.Position = 0;
				var nameOutputFile = CreateOutputFileName(inputFile);

				var writer = new StreamWriter(nameOutputFile);
				writer.Write(result.ReadToEnd());
				writer.Close();
			}
		}

		private String CreateOutputFileName(String inputFileName)
		{
			return inputFileName.Substring(0, inputFileName.LastIndexOf('/')) +
				_outputFilePattern.PrefixPattern +
				_inputFilePattern.GetNumberPart(inputFileName) +
				_outputFilePattern.SuffixPattern;
		}

		private readonly ITestOutputDataCreator _creator;
		private readonly IPlatformLogger _logger;
		private readonly String _workPath;
		private readonly TestFilePattern _inputFilePattern;
		private readonly TestFilePattern _outputFilePattern;
	}
}