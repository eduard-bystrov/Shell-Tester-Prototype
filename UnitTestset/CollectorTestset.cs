using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShellTester.CollectorsTests;
using ShellTester;
using System.Collections.Generic;
using System.Linq;
using ShellTester.ConfigProviders;

namespace UnitTestset
{
	[TestClass]
	public class CollectorTestset : BaseTestset
	{
		[TestMethod]
		public void PathCollector()
		{
			var collector = new PathCollectorTests(
						Logger,
						@"../Tests/test.zip"
					);

			var result = new List<Test>(collector.MakeTestBlocks());

			Assert.IsTrue(result.Count == 2);
		}


		[TestMethod]
		public void CorrectPasswordZipFile()
		{
			var collector = new ZipCollectorTests(
						Logger,
						@"../Tests/test.zip",
						Enumerable.Empty<String>()
					);

			var result = new List<Test>(collector.MakeTestBlocks());
		}

		[TestMethod]
		public void WrongPasswordZipFile()
		{
			var collector = new ZipCollectorTests(
						Logger,
						@"../Tests/test.zip",
						new String[] {"228", "123" }
					);

			var result = new List<Test>(collector.MakeTestBlocks());

			Assert.IsTrue(result.Count == 2);
		}

	}
}
