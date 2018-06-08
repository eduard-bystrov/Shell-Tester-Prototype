using Newtonsoft.Json;
using System;

namespace ShellTester
{
	public class TestResult : ITestResult
	{
		public TestResultKind Kind { get; set; }

		public TimeSpan ExecutionTime { get; set; }

		//TODO Extension ????
		public Int64 ExecutionTime_ms => Convert.ToInt32(ExecutionTime.TotalMilliseconds);
		public Int64 ExecutionTime_s => Convert.ToInt32(ExecutionTime.TotalSeconds);
		public Int64 ExecutionTime_m => Convert.ToInt32(ExecutionTime.TotalMinutes);


		public Int64 PeekMemory_bit { get; set; }
		public Int64 PeekMemory_mb { get; set; }


		public Int64 Price { get; set; }

		public TestDescription Description { get; set; }
		
		public String Id { get; set; }

		

		
	}
}