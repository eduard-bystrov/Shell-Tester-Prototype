using Logger;
using Logger.Enhanced;
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
			String workPath,
			TestFilePattern inputFilePattern,
			TestFilePattern outputFilePatten
		)
			: base(logger, workPath, inputFilePattern, outputFilePatten)
		{
		}

		public override IEnumerable<Test> MakeTestBlocks()
		{
			_logger.Info("Find test files...");

			String[] inputFiles = GetFilesByMask(_inputFilePattern.GetFullRegex());
			String[] outputFiles = GetFilesByMask(_outputFilePattern.GetFullRegex());

			var tests = MakeTestBlocks(inputFiles, outputFiles);

			_logger.Info("Test blocks ready");

			return tests;
		}

		private IEnumerable<Test> MakeTestBlocks(String[] inputFiles, String[] outputFiles)
		{
			String[] inputNumberFilenames = GetOnlyNumberFilenames(inputFiles, _inputFilePattern);
			String[] outpuNumberFilenames = GetOnlyNumberFilenames(outputFiles, _outputFilePattern);

			for (Int32 i = 0; i < inputNumberFilenames.Length; ++i)
			{
				for (Int32 j = 0; j < outpuNumberFilenames.Length; ++j)
				{
					String inNumber = inputNumberFilenames[i];
					String outNumber = outpuNumberFilenames[j];

					if (inNumber == outNumber)
					{
						yield return new Test(
							new StreamReader(inputFiles[i]),
							new StreamReader(outputFiles[j]),
							inputNumberFilenames[i]
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
	}
}