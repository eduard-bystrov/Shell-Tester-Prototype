using Newtonsoft.Json;
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
		private JsonTestsetSettings _settings;

		public StreamConfigTestsetSettings(StreamReader stream)
		{
			if (stream == null)
			{
				throw new NullReferenceException(nameof(StreamReader));
			}

			JsonTestsetSettings settings = JsonConvert.DeserializeObject<JsonTestsetSettings>(stream.ReadToEnd());

			_settings = settings;
		}

		public String Key => _settings.Key;

		public String TaskName => _settings.TaskkName;

		public String TestsetVersion => _settings.TestsetVersion;

		public Int32 DefaultTimeLimit_ms => _settings.Tests.DefaultTimeLimit_ms;

		public Int32 DefaultMemoryLimit_mb => _settings.Tests.DefaultMemoryLimit_mb;

		public Int32 DefaultPrice => _settings.Tests.DefaultPrice;

		public TestFilePattern InputFilePattern => _settings.Tests.InputMask.GetFileTestPattern();

		public TestFilePattern OuputFilePattern => _settings.Tests.OutputMask.GetFileTestPattern();

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
