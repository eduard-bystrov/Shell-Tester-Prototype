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

            StreamWriter streamWriter = process.StandardInput;
            StreamReader streamReaderInput = new StreamReader(test.inputFileName);
            streamWriter.Write(streamReaderInput.ReadToEnd());
			streamWriter.Close();
            process.WaitForExit();
           
			var res = CreateTestResult(process,test);

			process.Close();

			//Logger.Instance.Write(
			//            String.Format("IDEAL: {0} PROCESS: {1} {2}",
			//            processOutput, idealOutput, res.Type)
			//         );

			Logger.Instance.Write(String.Format("{0}",
				res.Type));

            return res;
        }

		private TestResult CreateTestResult(Process process,Test test)
		{
			StreamReader streamReaderIdeal = new StreamReader(test.idealOutputFileName);
			String idealOutput = streamReaderIdeal.ReadToEnd();
			String processOutput = process.StandardOutput.ReadToEnd();
			
			var res = new TestResult();

			bool accepted = (idealOutput == processOutput);

			if (accepted) res.Type = TestResultType.Success;
			else res.Type = TestResultType.WrongAnswer;

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
    }
}
