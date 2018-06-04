using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShellTester;
using ShellTester.CollectorsTests;
using ShellTester.ConfigProviders;
using ShellTester.CreatorsTestset;
using System;
using System.Linq;

namespace UnitTestset
{
	[TestClass]
	public class CreatorPackageTestset : BaseTestset
	{
		[TestMethod]
		private void CorrectCreate()
		{
			var creator = new TestsetCreator(
				new TestOutputDataCreator(@"../../Programs/AllTestAC.exe"),
				Logger,
				"@../../Tests/Creator/"
			);

			creator.Create();

			var collector = new PathCollectorTests(
						Logger,
						@"../Tests/test.zip"
					);

			Assert.IsTrue(collector.MakeTestBlocks().Any());
		}

		[TestMethod]
		[ExpectedException(typeof(Exception))]
		private void IncorectCreate()
		{
			var creator = new TestsetCreator(
				new TestOutputDataCreator(@"../../Programs/ErrorInProcess.exe"),
				Logger,
				"@../../Tests/Creator/"
			);

			creator.Create();

			var collector = new PathCollectorTests(
						Logger,
						@"../Tests/test.zip"
					);

			Assert.IsTrue(collector.MakeTestBlocks().Count() == 2);
		}
	}
}