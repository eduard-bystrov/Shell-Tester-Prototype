using Logger;
using Logger.Enhanced;
using ShellTester.ConfigProviders;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace ShellTester.CollectorsTests
{
	public class PathCollectorTests : AbstractCollectorTests
	{
		public PathCollectorTests(
			IPlatformLogger logger,
			IConfigTestsetProvider configProvider,
			String workPath
		)
			: base(logger, configProvider, workPath)
		{
		}

		public override IEnumerable<Test> MakeTestBlocks()
		{
			_logger.Info("Find test files...");

			String[] inputFiles = GetFilesByMask(InputFilePattern.GetFullRegex());
			String[] outputFiles = GetFilesByMask(OutputFilePattern.GetFullRegex());

			var tests = MakeTestBlocks(inputFiles, outputFiles);

			_logger.Info("Test blocks ready");

			return tests;
		}

		private IEnumerable<Test> MakeTestBlocks(String[] inputFiles, String[] outputFiles)
		{
			String[] inputNumberFilenames = GetOnlyNumberFilenames(inputFiles, InputFilePattern);
			String[] outpuNumberFilenames = GetOnlyNumberFilenames(outputFiles, OutputFilePattern);

			for (Int32 i = 0; i < inputNumberFilenames.Length; ++i)
			{
				for (Int32 j = 0; j < outpuNumberFilenames.Length; ++j)
				{
					String inNumber = inputNumberFilenames[i];
					String outNumber = outpuNumberFilenames[j];

					if (inNumber == outNumber)
					{
						var idTest = inputNumberFilenames[i];

						yield return new Test(
							new StreamReader(inputFiles[i]),
							new StreamReader(outputFiles[j]),
							idTest,
							_configTestsetProvider.TimeLimitFor(idTest),
							_configTestsetProvider.MemoryLimitFor(idTest)
						);
						break;
					}
				}
			}
		}

		private String[] GetOnlyNumberFilenames(String[] filenames, TestFilePattern pattern)
		{

			return filenames.Select(x => pattern.GetNumberPart(x)).ToArray();
		}


		private String[] GetFilesByMask(Regex reg)
		{
			return Directory.GetFiles(_workPath)
							.Where(file => reg.IsMatch(file))
							.ToArray();
		}

		public override IConfigTestsetProvider Config
		{
			get
			{
				return base.Config;
			}
		}
	}
}