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
						pathToProgram,
						new TestFilePattern(inMask),
						new TestFilePattern(outMask),
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

			Assert.IsTrue(results.Any(x => x.Type == TestResultType.MemoryLimitExceeded));
		}

		[TestMethod]
		public void TimeLimit()
		{
			var results = RunTester(@"../../test.zip", @"../../Programs/MemoryLimit.exe");

			Assert.IsTrue(results.Any(x => x.Type == TestResultType.TimeLimitExceeded));
		}

		[TestMethod]
		public void ErrorInProcess()
		{
			var results = RunTester(@"../../test.zip", @"../../Programs/MemoryLimit.exe");

			Assert.IsTrue(results.Any(x => x.Type == TestResultType.RuntimeError));
		}
		public void OutOfMemory()
		{
			var results = RunTester(@"../../test.zip", @"../../Programs/MemoryLimit.exe");

			Assert.IsTrue(results.Any(x => x.Type == TestResultType.RuntimeError));
		}

		[TestMethod]
		public void AllTestWA()
		{
			var results = RunTester(@"../../test.zip", @"../../Programs/MemoryLimit.exe");

			Assert.IsTrue(results.All(x => x.Type == TestResultType.WrongAnswer));
		}

		[TestMethod]
		public void AllTestAC()
		{
			var results = RunTester(@"../../test.zip", @"../../Programs/MemoryLimit.exe");

			Assert.IsTrue(results.All(x => x.Type == TestResultType.Success));
		}

		[TestMethod]
		public void SecondTestWA_RunAllTests()
		{
			var results = RunTester(@"../../test.zip", @"../../Programs/MemoryLimit.exe");

			Assert.IsTrue(results.All(x => x.Type == TestResultType.Success));
		}

		[TestMethod]
		public void SecondTestWA_RunWhileAC()
		{
			ITester tester = new Tester(
					Logger,
					new ZipCollectorTests(
						Logger,
						@"../../Tests/test.zip",
						new TestFilePattern(inMask),
						new TestFilePattern(outMask),
						new String[] { "228", "123" }

					),
					new WhileSuccessTestsLauncher
						(
							new OneTestRunner(
								Logger,
								new FullStreamComparer(),
								@"../../Tests/Programs/SecondTestWA.exe"
							)
						)
				);

			List<ShellTester.TestResult> results = new List<ShellTester.TestResult>(tester.Run());

			Assert.IsTrue(results.All(x => x.Type == TestResultType.Success));
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
