using Newtonsoft.Json;
using System;

namespace ShellTester
{
	public class TestResult : ITestResult
	{
		public TestResultType Type { get; set; }
		public TimeSpan ExecutionTime { get; set; }

		public TestDescription Description { get; set; }
		public Int64 PeekMemory { get; set; }

		public String ToJson
		{
			get
			{
				return JsonConvert.SerializeObject(this);
			}
		}
	}
}