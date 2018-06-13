using Logger;
using Logger.Enhanced;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace ShellTester
{
	public class OneTestRunner : IOneTestRunner
	{
		public OneTestRunner(
			IPlatformLogger logger,
			IEqualityComparer<StreamReader> comparer,
			String exeName
		)
		{
			_logger = logger;
			_comparer = comparer;
			_exeName = exeName;
		}

		public TestResult Run(Test test) // information about process (processInfo ???)
		{
			Process process = new Process() { StartInfo = CreateProcessInfo() };
			process.Start();

			_logger.Info(String.Format("Start test: {0}", test.InputStream));

			WriteInputDataToProcess(process, test);
			WaitProcessAndCollectData(process, test);

			_logger.Info(String.Format("End test: {0}", test.InputStream));

			var res = CreateTestResult(process, test);

			process.Close();

			return res;
		}

		private void WaitProcessAndCollectData(Process process, Test test)
		{

			do
			{
				if (!process.HasExited)
				{
					_peakPagedMem = process.PeakPagedMemorySize64;
					_peakVirtualMem = process.PeakVirtualMemorySize64;
					_peakWorkingSet = process.PeakWorkingSet64;
				}
			} while (!process.WaitForExit(TIME_REFRESH_DATA_ABOUT_PROCESS_MS) &&
				Memory_mb <= test.MemoryLimit_mb &&
				process.TotalProcessorTime.TotalMilliseconds <= test.TimeLimit_ms
				);

			if (!process.HasExited)
			{
				process.Close();
			}
		}


		private Int64 Memory_mb
		{
			get
			{
				return (_peakPagedMem + _peakVirtualMem + _peakWorkingSet) / 8 / 1024 / 1024;
			}
		}


		private void WriteInputDataToProcess(Process process, Test test)
		{
			StreamWriter streamWriter = process.StandardInput;
			StreamReader streamReaderInput = test.InputStream;
			streamWriter.Write(streamReaderInput.ReadToEnd());
			streamWriter.Close();
		}

		private TestResult CreateTestResult(Process process, Test test)
		{
			//StreamReader streamReaderIdeal = new StreamReader(test.IdealOutputFileName);

			var res = new TestResult()
			{
				Price = test.Price,
				Id = test.Id
			};

			//TODO Сравниватель файлов, доблы и тд
			Boolean accepted = _comparer.Equals(test.IdealOutputStream, process.StandardOutput);

			_logger.Info(String.Format("Result {0}", accepted));

			if (accepted)
			{
				res.Kind = TestResultKind.Success;
			}
			else
			{
				res.Kind = TestResultKind.WrongAnswer;
			}

			//TODO память точно верно(сравнить)
			res.ExecutionTime = process.TotalProcessorTime;
			res.PeekMemory_bit = _peakPagedMem + _peakVirtualMem + _peakWorkingSet;
			

			return res;
		}


		private ProcessStartInfo CreateProcessInfo()
		{
			return new ProcessStartInfo
			{
				FileName = _exeName,
				UseShellExecute = false,
				RedirectStandardOutput = true,
				RedirectStandardInput = true,
				CreateNoWindow = true
			};
		}

		private readonly IPlatformLogger _logger;
		private readonly IEqualityComparer<StreamReader> _comparer;
		private readonly String _exeName;

		private Int64 _peakPagedMem = 0;
		private Int64 _peakWorkingSet = 0;
		private Int64 _peakVirtualMem = 0;
		private Int64 Memory_b { get; set; }
		private Int64 Time_ms { get; set; }

		private Int32 TIME_REFRESH_DATA_ABOUT_PROCESS_MS => 1;
	}
}