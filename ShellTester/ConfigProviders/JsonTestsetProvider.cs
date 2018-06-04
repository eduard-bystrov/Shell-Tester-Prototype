using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellTester.ConfigProviders
{
	public class JsonTestsetProvider
	{

		public String TaskkName { get; set; }
		public String TestsetVersion { get; set; }
		public String Key { get; set; }
		public Tests Tests { get; set; }
	}

	public class Tests
	{
		public Int32 DefaultTimeLimit_ms { get; set; }
		public Int32 DefaultMemoryLimit_mb { get; set; }
		public Int32 DefaultPrice { get; set; }

		public FileTestPatternSettings InputMask { get; set; }
		public FileTestPatternSettings OutputMask { get; set; }

		public List<Customizations> Customizations { get; set; }

	}

	public class Customizations
	{
		public String Number { get; set; }
		public Int32 TimeLimit_ms { get; set; }
		public Int32 MemoryLimit_mb { get; set; }
		public Int32 Price { get; set; }


		//TODO Int32 ????
		public Boolean inRange(Int32 id)
		{
			return From >= id && id <= To;
		}

		private Int32 From
		{
			get
			{
				var index = Number.IndexOf('-');
				return index == -1 ? Int32.Parse(Number) : Int32.Parse(Number.Substring(0, index));
			}
		}

		private Int32 To
		{
			get
			{
				var index = Number.IndexOf('-');
				return index == -1 ? Int32.Parse(Number) : Int32.Parse(Number.Substring(index));
			}
		}
	}

	public class FileTestPatternSettings
	{
		public String Prefix { get; set; }
		public String Numeration { get; set; }
		public String Suffix { get; set; }


		public TestFilePattern GetFileTestPattern()
		{
			return new TestFilePattern($"({Prefix})({Numeration})({Suffix})");
		}
	}


}
