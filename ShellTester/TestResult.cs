using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellTester
{
	public class TestResult : ITestResult
	{
		public TestResultType Type
		{
			get;
			set;
		}

		public TimeSpan ExecutionTime
		{
			get;
			set;
		}

		public TestDescription Description
		{
			get;
			set;
		}
	}
}
