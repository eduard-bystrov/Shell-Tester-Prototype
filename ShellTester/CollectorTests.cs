using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace ShellTester
{
	public class CollectorTestsInPath : ICollectorTests
	{
		public CollectorTestsInPath(String workPath,
							  TestFilePattern inputFilePattern,
							  TestFilePattern outoutFilePatten)
		{
			_workPath = workPath;
			_inputFilePattern = inputFilePattern;
			_outputFilePattern = outoutFilePatten;
		}

		public IEnumerable<Test> MakeTestBlocks()
		{
			Logger.Instance.Write("Find test files...");

			String[] inputFiles = GetFilesByMask(_inputFilePattern.GetPattern);
			String[] outputFiles = GetFilesByMask(_outputFilePattern.GetPattern);

			var tests = MakeTestBlocks(inputFiles, outputFiles);

			Logger.Instance.Write("Test blocks ready");

			return tests;
		}

		//ignored not merged file
		//adding first asseptable
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
						yield return new Test(inputFiles[i], outputFiles[j]);
						break;
					}
				}
			}
		}

		private String[] GetOnlyNumberFilenames(String[] filenames, TestFilePattern pattern)
		{
			Int32 len = filenames.Length;
			String[] res = new String[len];
			for (Int32 i = 0; i < len; ++i)
			{
				var filename = filenames[i];
				res[i] = GetNumberOfTestFileName(filename, pattern);
			}
			return res;
		}

		private String[] GetFilesByMask(String pattern)
		{
			Regex reg = new Regex(pattern);
			return Directory.GetFiles(_workPath)
							.Where(file => reg.IsMatch(file))
							.ToArray();
		}

		//private string[] GetArrayOfNumberTest(string[] filesname, TestFilePattern pattern)
		//{
		//	var result = from filename in filesname
		//				 select GetNumberOfTestFileName(filename, pattern)
		//				 .ToArray().ToString();
		//	return result;
		//}

		private String GetNumberOfTestFileName(String fileName, TestFilePattern pattern)
		{
			String[] substrings = Regex.Split(fileName, pattern.GetPattern);
			Regex reg = new Regex(pattern._numberPattern);

			foreach (var substring in substrings)
			{
				if (reg.IsMatch(substring))
				{
					return substring;
				}
			}

			throw new NotImplementedException();
		}

		private readonly String _workPath;
		private readonly TestFilePattern _inputFilePattern;
		private readonly TestFilePattern _outputFilePattern;

		// может быть разбить на три блока и потом собирать их ?
		// парсить в один блок потом разбивать ?
		// что если два файла с одинаковым номером
		// что будет если преф. и/или суф. пустые
		// перемудрил, мб, вернуть как было )00000
	}
}