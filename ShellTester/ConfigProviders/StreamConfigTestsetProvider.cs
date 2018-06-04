using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellTester.ConfigProviders
{
	public class StreamConfigTestsetProvider : IConfigTestsetProvider
	{
		private JsonTestsetProvider _settings;

		public StreamConfigTestsetProvider(StreamReader stream)
		{
			if (stream == null)
			{
				throw new NullReferenceException(nameof(StreamReader));
			}

			JsonTestsetProvider settings = JsonConvert.DeserializeObject<JsonTestsetProvider>(stream.ReadToEnd());

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

		private Int32 MemoryLimitFor(Int32 testId)
		{
			Int32 result = DefaultMemoryLimit_mb;

			var wh = _settings.Tests.Customizations
				.Where(x => x.inRange(testId));

			if (wh.Any())
			{
				result = wh.First().MemoryLimit_mb;
			}

			return result;
		}

		private Int32 TimeLimitFor(Int32 testId)
		{
			Int32 result = DefaultTimeLimit_ms;

			var wh = _settings.Tests.Customizations
				.Where(x => x.inRange(testId));

			if (wh.Any())
			{
				result = wh.First().TimeLimit_ms;
			}

			return result;
		}

		private Int32 PriceFor(Int32 testId)
		{
			Int32 result = DefaultPrice;

			var wh = _settings.Tests.Customizations
				.Where(x => x.inRange(testId));

			//TODO Exception
			if (wh.Any())
			{
				result = wh.First().Price;
			}

			return result;
		}

		public Int32 TimeLimitFor(String testId)
		{
			return TimeLimitFor(Int32.Parse(testId));
		}

		public Int32 MemoryLimitFor(String testId)
		{
			return MemoryLimitFor(Int32.Parse(testId));
		}

		public Int32 PriceFor(String testId)
		{
			return PriceFor(Int32.Parse(testId));
		}
	}
}
