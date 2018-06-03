using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellTester.ConfigProviders
{
	public class StreamConfigTestsetSettings : IConfigTestsetSettings
	{
		public StreamConfigTestsetSettings(StreamReader stream)
		{
			if (stream == null)
			{
				throw new NullReferenceException(nameof(StreamReader));
			}

			
		}

		public String Key => throw new NotImplementedException();

		public String TaskName => throw new NotImplementedException();

		public String TestsetVersion => throw new NotImplementedException();

		public Int32 DefaultTimeLimit_ms => throw new NotImplementedException();

		public Int32 DefaultMemoryLimit_mb => throw new NotImplementedException();

		public Int32 DefaultPrice => throw new NotImplementedException();

		public TestFilePattern InputFilePattern => throw new NotImplementedException();

		public TestFilePattern OuputFilePattern => throw new NotImplementedException();

		public Int32 MemoryLimitFor(String testId)
		{
			throw new NotImplementedException();
		}

		public Int32 TimeLimitFor(String testId)
		{
			throw new NotImplementedException();
		}
	}
}
