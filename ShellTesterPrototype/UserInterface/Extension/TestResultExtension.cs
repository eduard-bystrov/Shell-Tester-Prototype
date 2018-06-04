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

		public static Int64 PercentageResult(this List<TestResult> results)
		{
			Int64 complete = results.Where(x => x.Kind == TestResultKind.Success).Sum(x => x.Price);
			Int64 total = results.Sum(x => x.Price);
			return (Int64)Math.Round((double)(100 * complete) / total);
		}

	}

}
