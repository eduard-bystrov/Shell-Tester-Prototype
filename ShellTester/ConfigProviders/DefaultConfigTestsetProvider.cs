using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellTester.ConfigProviders
{
	public class DefaultConfigTestsetProvider : IConfigTestsetProvider
	{
		public Int32 MemoryLimitFor(String testId)
		{
			return 512;
		}

		public Int32 TimeLimitFor(String testId)
		{
			return 10;
		}
	}
}
