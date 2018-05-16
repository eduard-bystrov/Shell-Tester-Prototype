using System;
using System.IO;

namespace ShellTester
{
	public class Test
	{
		public Test(
			StreamReader input,
			StreamReader output,
			String id
		)
		{
			InputStream = input;
			IdealOutputStream = output;
			Id = id;
		}

		public StreamReader InputStream { get; }
		public StreamReader IdealOutputStream { get; }
		public String Id { get; }
	}
}