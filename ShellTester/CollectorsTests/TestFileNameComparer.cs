using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellTester.CollectorsTests
{
	public class TestFileNameComparer : IEqualityComparer<String>
	{
		public TestFileNameComparer(TestFilePattern inPattern, TestFilePattern outPattern)
		{
			InPattern = inPattern;
			OutPattern = outPattern;
		}

		public Boolean Equals(String inName, String outName)
		{
			if (inName == null && outName == null) return true;
			if (inName == null || outName == null) return false;

			return InPattern.GetNumberPart(inName) == OutPattern.GetNumberPart(outName);
		}

		public Int32 GetHashCode(String obj)
		{
			return obj.GetHashCode();
		}


		private TestFilePattern InPattern { get; }
		private TestFilePattern OutPattern { get; }
	}
}
