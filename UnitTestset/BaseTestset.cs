using Logger;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShellTester;
using System;
using System.Collections.Generic;
using System.IO;

namespace UnitTestset
{
	[TestClass]
	public class BaseTestset
	{
		[TestInitialize]
		public virtual void TestInitialize()
		{
			Logger = new StreamLogger(new StreamWriter(DateTime.Now.Date.ToString("dd/MM/yyyy") + ".log") { AutoFlush = true });
		}

		public IEnumerable<ShellTester.TestResult> CreateSimpleTestResult()
		{
			return new List<ShellTester.TestResult>
				{
					{
						new ShellTester.TestResult
						{
							Description = new TestDescription
							{
								cost = 228,
								idealOutputFilePath = "123.txt",
								inputFilePath = "12312321312.txt"
							},
							ExecutionTime = TimeSpan.FromDays(12),
							Id = "500",
							PeekMemory_bit = Int32.MaxValue,
							Kind = TestResultKind.CompilationError
						}
					},
					{
						new ShellTester.TestResult
						{
							Description = new TestDescription
							{
								cost = 322,
								idealOutputFilePath = "51235.txt",
								inputFilePath = "789745.txt"
							},
							ExecutionTime = TimeSpan.FromMilliseconds(10),
							Id = "31",
							PeekMemory_bit = 51235512,
							Kind = TestResultKind.RuntimeError
						}
					},
					{
						new ShellTester.TestResult
						{
							Description = new TestDescription
							{
								cost = 322,
								idealOutputFilePath = "12312.txt",
								inputFilePath = "3123123.txt"
							},
							ExecutionTime = TimeSpan.FromMilliseconds(10),
							Id = "214",
							PeekMemory_bit = 123456,
							Kind = TestResultKind.Success
						}
					}
				};
		}

		protected static readonly string inMask = @"(input)(\d+)(.txt)";
		protected static readonly string outMask = @"(output)(\d+)(.txt)";
		protected virtual IPlatformLogger Logger { get; set; }
	}
}