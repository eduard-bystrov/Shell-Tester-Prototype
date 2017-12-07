using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace ShellTester
{
    class OneTestRunner : IOneTestRunner
	{
        public TestResult Run(TestBlock test) // information about process (processInfo ???)
        {
			Process process = new Process() { StartInfo = CreateProcessInfo() };
            process.Start();

            StreamWriter streamWriter = process.StandardInput;
            StreamReader streamReaderInput = new StreamReader(test.inputFileName);
            streamWriter.Write(streamReaderInput.ReadToEnd());
            streamWriter.Close();

            String processOutput = process.StandardOutput.ReadToEnd();

            process.WaitForExit();

            process.Close();

            StreamReader streamReaderIdeal = new StreamReader(test.idealOutputFileName);
            String idealOutput = streamReaderIdeal.ReadToEnd();

            var res = new TestResult();
			bool accepted = (idealOutput == processOutput);

			if (accepted) res.Type = TestResultType.Success;
			else res.Type = TestResultType.WrongAnswer;

			Logger.Instance.Write(
               String.Format("IDEAL: {0} PROCESS: {1} {2}",
               processOutput, idealOutput, res.Type)
            );


            return res;
        }

		private ProcessStartInfo CreateProcessInfo()
		{
			return new ProcessStartInfo
			{
				FileName = "plus.exe",
				UseShellExecute = false,
				RedirectStandardOutput = true,
				RedirectStandardInput = true
			};
		}
    }
}
