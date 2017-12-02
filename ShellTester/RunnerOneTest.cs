using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace ShellTester
{
    class RunnerOneTest : IRunnerOneTest
    {
        public ResultTest Run(TestBlock test) // information about process (processInfo ???)
        {
            ProcessStartInfo info = new ProcessStartInfo
            {
                FileName = "plus.exe",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardInput = true
            };

            Process process = new Process();
            process.StartInfo = info;
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


            var res = new ResultTest();
            res.success = idealOutput == processOutput;

            Logger.Instance.Write(
               String.Format("IDEAL: {0} PROCESS: {1} SUCCESS:{2}",
               processOutput, idealOutput,res.success)
            );


            return res;
        }
    }
}
