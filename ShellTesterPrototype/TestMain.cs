using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShellTester;
using System.Diagnostics;
using System.IO;

namespace ShellTesterPrototype
{
    class Program
    {
        static void Main(string[] args)
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
            streamWriter.WriteLine("1 5");
            streamWriter.Close();
            
            string s = process.StandardOutput.ReadToEnd();
            Logger.Instance.Write(s);
            process.WaitForExit();
            process.Close();

            process.Start();
        }
    }
}
