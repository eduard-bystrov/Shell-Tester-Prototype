using Logger;
using ShellTester.ConfigProviders;
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
			String workPath
		)
		{
			_creator = creator ?? throw new NullReferenceException(nameof(ITestOutputDataCreator));
			_logger = logger ?? throw new NullReferenceException(nameof(IPlatformLogger));
			_workPath = workPath;
		}

		public void Create()
		{
			var inputFiles = Directory.GetFiles(_workPath)
							.Where(file => InputFilePattern.GetFullRegex().IsMatch(file));

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
				Config.OuputFilePattern.PrefixPattern +
				Config.InputFilePattern.GetNumberPart(inputFileName) +
				Config.OuputFilePattern.SuffixPattern;
		}

		public IConfigTestsetProvider Config { get; }
		public TestFilePattern InputFilePattern { get => Config.InputFilePattern; }

		private readonly ITestOutputDataCreator _creator;
		private readonly IPlatformLogger _logger;
		private readonly String _workPath;
	}
}