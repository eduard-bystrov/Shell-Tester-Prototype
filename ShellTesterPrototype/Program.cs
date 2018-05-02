using Fclp;
using ShellTester;
using System;

namespace ShellTesterPrototype
{
	internal class Program
	{
		private static void Main(String[] args)
		{
			var parser = new FluentCommandLineParser();

			String exe = null;
			String inMask = null, outMask = null;
			String path = null;

			parser.Setup<String>("p", longOption: "path")
				.Callback(e => path = e);
			parser.Setup<String>("e", longOption: "exe")
				.Callback(e => exe = e);
			parser.Setup<String>(longOption: "inMask")
				.Callback(e => inMask = e);
			parser.Setup<String>(longOption: "outMask")
				.Callback(e => outMask = e);

			parser.Parse(args);

			Logger.Instance.Write(exe);

			ITester tester = new Tester(
				new CollectorTestsInPath(path,
					new TestFilePattern(inMask),
					new TestFilePattern(outMask)

				),
				new CheckAllTestsLauncher
					(
						new OneTestRunner(exe)
					)
			);
			tester.Run();
		}
	}
}