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
			String path = "1";
			parser.Setup<String>("p", "path")
				.Callback(p => path = p);
			parser.Parse(args);

			Logger.Instance.Write(path);

			ITester tester = new Tester(
				new CollectorTests(),
				new CheckAllTestsLauncher
					(
						new OneTestRunner()
					)
            );
            tester.Run();

			
		}
    }
}
