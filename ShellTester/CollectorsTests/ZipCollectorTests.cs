﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Logger;
using SevenZipLib;

namespace ShellTester.CollectorsTests
{
	public class ZipCollectorTests : AbstractCollectorTests
	{
		public ZipCollectorTests(
			IPlatformLogger logger,
			String workPath,
			TestFilePattern inputFilePattern,
			TestFilePattern outputFilePatten,
			IEnumerable<String> passwords
		) 
			: base(logger, workPath, inputFilePattern, outputFilePatten)
		{
			_passwords = passwords;
		}

		//TODO 
		public override IEnumerable<Test> MakeTestBlocks()
		{
			using (var archive = new SevenZipArchive(_workPath))
			{
				var inputFiles = archive.Where(x => _inputFilePattern.GetFullRegex().IsMatch(x.FileName));
				var ouputFiles = archive.Where(x => _outputFilePattern.GetFullRegex().IsMatch(x.FileName));
				var comparer = new TestFileNameComparer(_inputFilePattern, _outputFilePattern);

				foreach (var inputFile in inputFiles)
				{
					foreach (var outputFile in ouputFiles)
					{
						var inName = inputFile.FileName;
						var outName = outputFile.FileName;

						if (comparer.Equals(inName, outName))
						{
							yield return new Test(
								inputFile.ExtractToStreamReader(),
								outputFile.ExtractToStreamReader(),
								_inputFilePattern.GetNumberPart(inName)
							);
						}
					}
				}
			}
		}

		//TODO
		[Obsolete]
		private class ArchiveEntryComparer : IEqualityComparer<ArchiveEntry>
		{
		
			public Boolean Equals(ArchiveEntry lsh, ArchiveEntry rsh)
			{
				throw new NotImplementedException();
			}

			public Int32 GetHashCode(ArchiveEntry obj)
			{
				return obj.GetHashCode();
			}
		}

		private readonly IEnumerable<String> _passwords;
	}
}