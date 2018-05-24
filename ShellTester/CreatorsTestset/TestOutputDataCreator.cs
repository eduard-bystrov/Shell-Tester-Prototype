using System;
using System.Diagnostics;
using System.IO;

namespace ShellTester.CreatorsTestset
{
	public class TestOutputDataCreator : ITestOutputDataCreator
	{
		public TestOutputDataCreator(String pathToProgram)
		{
			_pathToProgram = pathToProgram;
		}

		public StreamReader Create(StreamReader inputData)
		{
			Process process = new Process() { StartInfo = CreateProcessInfo() };
			process.Start();

			StreamWriter streamWriter = process.StandardInput;
			streamWriter.Write(inputData.ReadToEnd());

			process.WaitForExit();

			return process.StandardOutput;
		}

		private ProcessStartInfo CreateProcessInfo()
		{
			return new ProcessStartInfo
			{
				FileName = _pathToProgram,
				UseShellExecute = false,
				RedirectStandardOutput = true,
				RedirectStandardInput = true
			};
		}

		private readonly String _pathToProgram;
	}
}