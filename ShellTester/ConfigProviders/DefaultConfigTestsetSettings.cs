﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellTester.ConfigProviders
{
	public class DefaultConfigTestsetSettings : IConfigTestsetSettings
	{
		public String Key => "secret";

		public String TaskName => "DefaultName";

		public Int32 DefaultTimeLimit_ms => 10;

		public Int32 DefaultMemoryLimit_mb => 512;

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

		public Int32 TimeLimitFor(String testId)
		{
			return DefaultTimeLimit_ms;
		}
	}
}