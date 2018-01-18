using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace ShellTester
{
	public class CollectorTests : ICollectorTests
	{
		public CollectorTests(string workPath,
							  string inputFilePattern = INPUT_FILE_PATTERN_DEFAULT,
							  string outoutFilePatten = OUTPUT_FILE_PATTERN_DEFAULT)
		{
			_workPath = workPath;
			_inputFileReg = new Regex(inputFilePattern);
			_outputFileReg = new Regex(outoutFilePatten);

		}
		public Test[] MakeTestBlocks()
		{
			Logger.Instance.Write("Finding test files...");

			var inputFiles = GetFilesByMask(_inputFileReg);
			var outputFiles = GetFilesByMask(_outputFileReg);

			var tests = new Test[inputFiles.Length];

			for (int i = 0; i < inputFiles.Length; ++i)
			{
				tests[i].inputFileName = inputFiles[i];
				tests[i].idealOutputFileName = outputFiles[i];
			};

			Logger.Instance.Write("Test blocks ready");

			return tests;
		}


		private string[] GetFilesByMask(Regex reg)
		{
			return Directory.GetFiles(_workPath)
							.Where(file => reg.IsMatch(file))
							.ToArray();
		}



		private readonly string _workPath; 
		private readonly Regex _inputFileReg;  // suf num pref 
		private readonly Regex _outputFileReg;// suf num pref
		private const string INPUT_FILE_PATTERN_DEFAULT = @"(input)([\d] +)(.txt)";
		private const string OUTPUT_FILE_PATTERN_DEFAULT = @"(output)([\d]+)(.txt)";
		// может быть разбить на три блока и потом собирать их ?
		// парсить в один блок потом разбивать ?
		// что если два файла с одинаковым номером


	}
}
