using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellTester.ConfigProviders
{
	public interface IConfigTestsetProvider
	{
		Int32 TimeLimitFor(String testId);
		Int32 MemoryLimitFor(String testId);
	}
}
