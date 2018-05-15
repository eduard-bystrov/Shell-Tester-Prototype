using Fclp;
using Logger;
using Logger.Enhanced;
using Postman;
using ShellTester;
using System;
using System.Collections.Generic;
using System.IO;

namespace ShellTesterPrototype
{
	internal class Program
	{
		private static void Main(String[] args)
		{

			using (var logger = new StreamLogger(new StreamWriter(DateTime.Now.Date.ToString("dd/MM/yyyy") + ".log") { AutoFlush = true }))
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

				logger.Info(exe);

				ITester tester = new Tester(
					logger,
					new CollectorTestsInPath(
						logger,
						path,
						new TestFilePattern(inMask),
						new TestFilePattern(outMask)

					),
					new CheckAllTestsLauncher
						(
							new OneTestRunner(
								logger,
								exe
							)
						)
				);
				var result = tester.Run();

				List<TestResult> l = new List<TestResult>(result);

				IPostman postman = new GmailPostman("testersfedu@gmail.com", "123456vkr^^", "TesterSfedu");

				postman.Send("eipii0@yandex.ru", "Test", l);
				
			}

		}
	}
}