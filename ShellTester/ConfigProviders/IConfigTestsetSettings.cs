using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellTester.ConfigProviders
{
	public interface IConfigTestsetSettings
	{
		Int32 TimeLimitFor(String testId);
		Int32 MemoryLimitFor(String testId);
		Int32 PriceFor(String testId);


		String Key { get; }
		String TaskName { get; }
		String TestsetVersion { get; }
		Int32 DefaultTimeLimit_ms { get; }
		Int32 DefaultMemoryLimit_mb { get; }
		Int32 DefaultPrice { get; }

		TestFilePattern InputFilePattern { get; }
		TestFilePattern OuputFilePattern { get; }
	}
}
