using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShellTester.CollectorsTests;
using ShellTester;
using Logger;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestset
{
	[TestClass]
	public class MainTestset : BaseTestset
	{

       

        private ITester CreateTester(String pathToTests, String pathToProgram)
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

            return tester;
        }

        [TestMethod]
		public void MemoryLimit()
		{
            var tester = CreateTester(@"../Tests/test.zip", @"../Tests/Programs/MemoryLimit.exe");

            List<ShellTester.TestResult> results = new List<ShellTester.TestResult>(tester.Run());

            Assert.IsTrue(results.Any(x => x.Type == TestResultType.MemoryLimitExceeded));
        }

		[TestMethod]
		public void TimeLimit()
		{
            var tester = CreateTester(@"../Tests/test.zip", @"../Tests/Programs/TimeLimit.exe");

            List<ShellTester.TestResult> results = new List<ShellTester.TestResult>(tester.Run());

            Assert.IsTrue(results.Any(x => x.Type == TestResultType.TimeLimitExceeded));
        }

		[TestMethod]
		public void ErrorInProcess()
		{
            var tester = CreateTester(@"../Tests/test.zip", @"../Tests/Programs/DivideByZero.exe");

            List<ShellTester.TestResult> results = new List<ShellTester.TestResult>(tester.Run());

            Assert.IsTrue(results.Any(x => x.Type == TestResultType.RuntimeError));
        }
		public void OutOfMemory()
		{
            var tester = CreateTester(@"../Tests/test.zip", @"../Tests/Programs/OutOfMemory.exe");

            List<ShellTester.TestResult> results = new List<ShellTester.TestResult>(tester.Run());

            Assert.IsTrue(results.Any(x => x.Type == TestResultType.RuntimeError));
        }

		[TestMethod]
		public void AllTestWA()
		{
            var tester = CreateTester(@"../Tests/test.zip", @"../Tests/Programs/AllTestWA.exe");

            List<ShellTester.TestResult> results = new List<ShellTester.TestResult>(tester.Run());

            Assert.IsTrue(results.All(x => x.Type == TestResultType.WrongAnswer));
        }

		[TestMethod]
		public void AllTestAC()
		{
            var tester = CreateTester(@"../Tests/test.zip", @"../Tests/Programs/AllTestAC.exe");

            List<ShellTester.TestResult> results = new List<ShellTester.TestResult>(tester.Run());

            Assert.IsTrue(results.All(x => x.Type == TestResultType.Success));
        }

		[TestMethod]
		public void SecondTestWA_RunAllTests()
		{
            var tester = CreateTester(@"../Tests/test.zip", @"../Tests/Programs/SecondTestWA.exe");

            List<ShellTester.TestResult> results = new List<ShellTester.TestResult>(tester.Run());

            Assert.IsTrue(results.All(x => x.Type == TestResultType.Success));
        }

		[TestMethod]
		public void SecondTestWA_RunWhileAC()
		{

		}



		[TestMethod]
		public void SerializationJson()
		{

		}

		[TestMethod]
		public void DeserializationJson()
		{

		}

		[TestMethod]
		public void ErrorInConfigFile()
		{
		}

	}
}
