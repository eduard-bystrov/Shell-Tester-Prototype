﻿using Fclp;
using Logger;
using Logger.Enhanced;
using Postman;
using ShellTester;
using ShellTester.CollectorsTests;
using ShellTester.ConfigProviders;
using ShellTester.Launchers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

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
				String path = null;

				parser.Setup<String>("p", longOption: "path")
					.Callback(e => path = e);
				parser.Setup<String>("e", longOption: "exe")
					.Callback(e => exe = e);

				parser.Parse(args);

				logger.Info(exe);

				ITester tester = new Tester(
					logger,
					new ZipCollectorTests(
						logger,
						path,
						new String[] {"228", "123"}

					),
					new CheckAllTestsLauncher
						(
							new OneTestRunner(
								logger,
								new FullStreamComparer(),
								exe
							)
						)
				);

				var result = tester.Run();

				List<TestResult> l = new List<TestResult>(result);

				IPostman postman = new GmailPostman(logger, "testersfedu@gmail.com", "123456vkr^^", "TesterSfedu");

				postman.Send("eipii0@yandex.ru", "Test", l);
				
			}

		}
	}
}