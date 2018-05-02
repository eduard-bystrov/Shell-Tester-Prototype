using System;

namespace ShellTester
{
	public class Test
	{
		public Test(String input, String output)
		{
			inputFileName = input;
			idealOutputFileName = output;
		}

		public String inputFileName;
		public String idealOutputFileName;
	}
}