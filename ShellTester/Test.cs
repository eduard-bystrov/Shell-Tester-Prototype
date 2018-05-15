using System;

namespace ShellTester
{
	public class Test
	{
		public Test(
			String input,
			String output,
			Int32 id
		)
		{
			InputFileName = input;
			IdealOutputFileName = output;
			Id = id;
		}

		public String InputFileName { get; }
		public String IdealOutputFileName { get; }
		public Int32 Id { get; }
	}
}