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
		public CollectorTests(string workPath)
		{
			_workPath = workPath;
		}
		public Test[] MakeTestBlocks()
		{
			var inputFiles = GetFilesByMask(_inputFilePattern);
			var outputFiles = GetFilesByMask(_outputFilePattern);

			var tests = new Test[inputFiles.Length];

			for (int i = 0; i < inputFiles.Length; ++i)
			{
				tests[i].inputFileName = inputFiles[i];
				tests[i].idealOutputFileName = outputFiles[i];
			};

			return tests;
		}


		private string[] GetFilesByMask(string mask)
		{
			Regex reg = new Regex(mask);
			return Directory.GetFiles(_workPath)
							.Where(path => reg.IsMatch(path))
							.ToArray();
		}


		private readonly string _workPath; 
		private string _inputFilePattern = @"input00.txt";
		private string _outputFilePattern = @"output00.txt";

		
	}
}
