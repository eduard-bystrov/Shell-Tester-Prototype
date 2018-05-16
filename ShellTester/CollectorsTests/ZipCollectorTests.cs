using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
		public IEnumerable<Test> MakeTestBlocks()
		{
			using (var archive = new SevenZipArchive(_workPath))
			{
				var inputFiles = archive.Where(x => _inputFilePattern.GetFullRegex().IsMatch(x.FileName));
				var ouputFiles = archive.Where(x => _outputFilePattern.GetFullRegex().IsMatch(x.FileName));

				var intersection = inputFiles.Intersect(ouputFiles, new ArchiveEntryComparer());
			}

			return Enumerable.Empty<Test>();
		}



		private class ArchiveEntryComparer : IEqualityComparer<ArchiveEntry>
		{
		
			public Boolean Equals(ArchiveEntry lsh, ArchiveEntry rsh)
			{
				if (lsh == null && rsh == null) return true;
				if (lsh == null || rsh == null) return false;



				return false;
			}

			public Int32 GetHashCode(ArchiveEntry obj)
			{
				return obj.GetHashCode();
			}
		}



		private readonly IEnumerable<String> _passwords;
	}
}
