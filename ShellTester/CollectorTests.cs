using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace ShellTester
{
	public class CollectorTestsInPath : ICollectorTests
	{
		public CollectorTestsInPath(string workPath,
							  TestFilePattern inputFilePattern,
							  TestFilePattern outoutFilePatten)
		{
			_workPath = workPath;
			_inputFilePattern = inputFilePattern;
			_outputFilePattern = outoutFilePatten;
		}
		public Test[] MakeTestBlocks()
		{
			Logger.Instance.Write("Find test files...");

			string[] inputFiles = GetFilesByMask(_inputFilePattern.GetPattern);
			string[] outputFiles = GetFilesByMask(_outputFilePattern.GetPattern);

			var tests = MakeTestBlocks(inputFiles, outputFiles);

			Logger.Instance.Write("Test blocks ready");
			
			return tests;
		}

		//ignored not merged file
		//adding first asseptable
		private Test[] MakeTestBlocks(string[] inputFiles, string[] outputFiles)
		{
			List<Test> tests = new List<Test>();

			string[] inputNumberFilenames = GetOnlyNumberFilenames(inputFiles, _inputFilePattern);
			string[] outpuNumberFilenames = GetOnlyNumberFilenames(outputFiles, _outputFilePattern);

			for (int i = 0; i < inputNumberFilenames.Length; ++i)
			{
				for (int j = 0; j < outpuNumberFilenames.Length; ++j)
				{
					string inNumber = inputNumberFilenames[i];
					string outNumber = outpuNumberFilenames[j];

					if (inNumber == outNumber)
					{
						Test test = new Test(inputFiles[i],outputFiles[j]);
						tests.Add(test);
						break;
					}
				}
			}

			return tests.ToArray();
		}
		private string[] GetOnlyNumberFilenames(string[] filenames, TestFilePattern pattern)
		{
			int len = filenames.Length;
			string[] res = new string[len];
			for (int i = 0; i < len; ++i)
			{
				var filename = filenames[i];
				res[i] = GetNumberOfTestFileName(filename,pattern);
			}
			return res;
		}

		private string[] GetFilesByMask(string pattern)
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

		private string GetNumberOfTestFileName(string fileName, TestFilePattern pattern)
		{
			string[] substrings = Regex.Split(fileName,pattern.GetPattern);
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

		private readonly string _workPath; 
		private readonly TestFilePattern _inputFilePattern;
		private readonly TestFilePattern _outputFilePattern;

		// может быть разбить на три блока и потом собирать их ?
		// парсить в один блок потом разбивать ?
		// что если два файла с одинаковым номером
		// что будет если преф. и/или суф. пустые
		// перемудрил, мб, вернуть как было )00000
	}
}
