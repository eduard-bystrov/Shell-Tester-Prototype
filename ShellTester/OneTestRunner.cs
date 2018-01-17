using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace ShellTester
{
    public class OneTestRunner : IOneTestRunner
	{
		public OneTestRunner(string exeName)
		{
			_exeName = exeName;
		}
        public TestResult Run(Test test) // information about process (processInfo ???)
        {
			Process process = new Process() { StartInfo = CreateProcessInfo() };
            process.Start();

			Logger.Instance.Write(String.Format("Start test: {0}", test.inputFileName));

			WriteInputDataToProcess(process, test);
			WaitProcessAndCollectData(process);

			Logger.Instance.Write(String.Format("End test: {0}", test.inputFileName));

			var res = CreateTestResult(process,test);

			process.Close();

            return res;
        }

		private void WaitProcessAndCollectData(Process process)
		{
			do
			{
				if (!process.HasExited)
				{
					_peakPagedMem = process.PeakPagedMemorySize64;
					_peakVirtualMem = process.PeakVirtualMemorySize64;
					_peakWorkingSet = process.PeakWorkingSet64;
				}
			} while (!process.WaitForExit(TIME_REFRESH_DATA_ABOUT_PROCESS_MS));
		}

		private void WriteInputDataToProcess(Process process,Test test)
		{
			StreamWriter streamWriter = process.StandardInput;
			StreamReader streamReaderInput = new StreamReader(test.inputFileName);
			streamWriter.Write(streamReaderInput.ReadToEnd());
			streamWriter.Close();
		}

		private TestResult CreateTestResult(Process process,Test test)
		{
			StreamReader streamReaderIdeal = new StreamReader(test.idealOutputFileName);
			String idealOutput = streamReaderIdeal.ReadToEnd();
			String processOutput = process.StandardOutput.ReadToEnd();
			
			var res = new TestResult();
			
			bool accepted = (idealOutput == processOutput);

			if (accepted)
			{
				res.Type = TestResultType.Success;
			}
			else
			{
				res.Type = TestResultType.WrongAnswer;
			}

			res.ExecutionTime = process.TotalProcessorTime;
			res.PeekMemory = _peakPagedMem + _peakVirtualMem + _peakWorkingSet;
			
			return res;
		}

		private ProcessStartInfo CreateProcessInfo()
		{
			return new ProcessStartInfo
			{
				FileName = _exeName,
				UseShellExecute = false,
				RedirectStandardOutput = true,
				RedirectStandardInput = true
			};
		}

		private readonly string _exeName;

		private Int64 _peakPagedMem = 0;
		private Int64 _peakWorkingSet = 0;
		private Int64 _peakVirtualMem = 0;


		private const int TIME_REFRESH_DATA_ABOUT_PROCESS_MS = 1000;
    }
}
