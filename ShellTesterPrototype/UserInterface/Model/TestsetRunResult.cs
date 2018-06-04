using ShellTester;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterface.Model
{
	public class TestsetRunResult
	{
		public String Name { get; private set; }
		public List<TestResult> Result { get; private set; }
		public String ArchiveName { get; private set; }
		public String TestsetVersion { get; private set; }
		public String Key { get; private set; }


		public TestsetRunResult(
			String name,
			String archiveName,
			String testsetVersion,
			String key,
			List<TestResult> results)
		{
			Name = name;
			ArchiveName = archiveName;
			TestsetVersion = testsetVersion;
			Key = key;
			Result = results;
		}


		public override String ToString()
		{
			return Name;
		}
	}
}
