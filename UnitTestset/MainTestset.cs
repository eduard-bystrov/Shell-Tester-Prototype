using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShellTester.CollectorsTests;
using ShellTester;
using Logger;
using System.Collections.Generic;
using System.Linq;
using ShellTester.Launchers;
using Newtonsoft.Json;
using System.IO;
using ShellTester.ConfigProviders;

namespace UnitTestset
{
	[TestClass]
	public class MainTestset : BaseTestset
	{

		private List<ShellTester.TestResult> RunTester(String pathToTests, String pathToProgram)
		{
			ITester tester = new Tester(
					Logger,
					new ZipCollectorTests(
						Logger,
						new DefaultConfigTestsetProvider(),
						pathToProgram,
						new String[] { "228", "123" }

					),
					new CheckAllTestsLauncher
						(
							new OneTestRunner(
								Logger,
								new FullStreamComparer(),
								pathToProgram
							)
						)
				);

			return new List<ShellTester.TestResult>(tester.Run());
		}

		[TestMethod]
		public void MemoryLimit()
		{
			var results = RunTester(@"../../test.zip", @"../../Programs/MemoryLimit.exe");

			Assert.IsTrue(results.Any(x => x.Kind == TestResultKind.MemoryLimitExceeded));
		}

		[TestMethod]
		public void TimeLimit()
		{
			var results = RunTester(@"../../test.zip", @"../../Programs/TimeLimit.exe");

			Assert.IsTrue(results.Any(x => x.Kind == TestResultKind.TimeLimitExceeded));
		}

		[TestMethod]
		public void ErrorInProcess()
		{
			var results = RunTester(@"../../test.zip", @"../../Programs/ErrorInProcess.exe");

			Assert.IsTrue(results.Any(x => x.Kind == TestResultKind.RuntimeError));
		}
		public void OutOfMemory()
		{
			var results = RunTester(@"../../test.zip", @"../../Programs/OutOfMemory.exe");

			Assert.IsTrue(results.Any(x => x.Kind == TestResultKind.RuntimeError));
		}

		[TestMethod]
		public void AllTestWA()
		{
			var results = RunTester(@"../../test.zip", @"../../Programs/AllTestWA.exe");

			Assert.IsTrue(results.All(x => x.Kind == TestResultKind.WrongAnswer));
		}

		[TestMethod]
		public void AllTestAC()
		{
			var results = RunTester(@"../../test.zip", @"../../Programs/AllTestAC.exe");

			Assert.IsTrue(results.All(x => x.Kind == TestResultKind.Success));
		}

		[TestMethod]
		public void SecondTestWA_RunAllTests()
		{
			var results = RunTester(@"../../test.zip", @"../../Programs/SecondWa.exe");

			Assert.IsTrue(results.All(x => x.Kind == TestResultKind.Success));
		}

		[TestMethod]
		public void SecondTestWA_RunWhileAC()
		{
			ITester tester = new Tester(
					Logger,
					new ZipCollectorTests(
						Logger,
						new DefaultConfigTestsetProvider(),
						@"../../Tests/test.zip",
						new String[] { "228", "123" }

					),
					new WhileSuccessTestsLauncher
						(
							new OneTestRunner(
								Logger,
								new FullStreamComparer(),
								@"../../Tests/Programs/SecondWa.exe"
							)
						)
				);

			List<ShellTester.TestResult> results = new List<ShellTester.TestResult>(tester.Run());

			Assert.IsTrue(results.All(x => x.Kind == TestResultKind.Success));
		}



		[TestMethod]
		public void SerializationJson()
		{
			var res = CreateSimpleTestResult();
			var json = JsonConvert.SerializeObject(res);

			var streamReader = new StreamReader(@"../../idealOutput.json");

			Assert.AreEqual(json, streamReader.ReadToEnd());

		}

		[TestMethod]
		public void DeserializationJson()
		{
			var streamReader = new StreamReader(@"../../idealOutput.json");
			var res = JsonConvert.DeserializeObject<List<ShellTester.TestResult>>(streamReader.ReadToEnd());
			var idealRes = new List<ShellTester.TestResult>(CreateSimpleTestResult());

			Assert.AreEqual(res.First().Description.cost, idealRes.First().Description.cost);

			
		}

		[TestMethod]
		[ExpectedException(typeof(JsonSerializationException))]
		public void ErrorInConfigFile()
		{
			var streamReader = new StreamReader(@"../../errorConfig.json");
			var res = JsonConvert.DeserializeObject<List<ShellTester.TestResult>>(streamReader.ReadToEnd());
		}

	}
}
