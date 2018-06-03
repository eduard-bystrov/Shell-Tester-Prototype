using ShellTester;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterface.Extension
{
	public static class TestResultExtension
	{
		public static String StringResult(this List<TestResult> result)
		{
			return $"{result.Count(x => x.Kind == TestResultKind.Success)}/{result.Count}";
		}
	}

}
