using Newtonsoft.Json;
using System;

namespace ShellTester
{
	public class TestResult : ITestResult
	{
		public TestResultKind Kind { get; set; }

		public TimeSpan ExecutionTime { get; set; }
		public Int32 ExecutionTime_ms => Convert.ToInt32(ExecutionTime.TotalMilliseconds);
		public Int32 ExecutionTime_s => Convert.ToInt32(ExecutionTime.TotalSeconds);
		public Int32 ExecutionTime_m => Convert.ToInt32(ExecutionTime.TotalMinutes);


		public TestDescription Description { get; set; }
		public Int64 PeekMemory { get; set; }
		public String Id { get; set; }

		

		
	}
}