using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ShellTester;
using Fclp;

namespace ShellTesterPrototype
{
    class Program
    {
        static void Main(string[] args)
        {
			var parser = new FluentCommandLineParser();
			String exe = "plus.exe";
			parser.Setup<String>("e", "exe")
				.Callback(e => exe = e);
			parser.Parse(args);

			Logger.Instance.Write(exe);

			ITester tester = new Tester(
				new CollectorTests(@"C:\FкFс\Shell-Tester-Prototype\test",
					new TestFilePattern(@"(input)(\d+)(.txt)"),
					new TestFilePattern(@"(output)(\d+)(.txt)")
				
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
