using System;

namespace ShellTester.ConfigProviders
{
	public class DefaultConfigTestsetProvider : IConfigTestsetProvider
	{
		public String Key => "secret";

		public String TaskName => "DefaultName";

		public Int32 DefaultTimeLimit_ms => 1000;

		public Int32 DefaultMemoryLimit_mb => 256;

		public Int32 DefaultPrice => 1;

		public String TestsetVersion => "1.0.0.0 DefaultConfig";

		public TestFilePattern InputFilePattern
		{
			get
			{
				return new TestFilePattern(@"(input)(\d+)(.txt)");
			}
		}

		public TestFilePattern OuputFilePattern
		{
			get
			{
				return new TestFilePattern(@"(output)(\d+)(.txt)");
			}
		}

		public Int32 MemoryLimitFor(String testId)
		{
			return DefaultMemoryLimit_mb;
		}

		public Int32 PriceFor(String testId)
		{
			return DefaultPrice;
		}

		public Int32 TimeLimitFor(String testId)
		{
			return DefaultTimeLimit_ms;
		}
	}
}