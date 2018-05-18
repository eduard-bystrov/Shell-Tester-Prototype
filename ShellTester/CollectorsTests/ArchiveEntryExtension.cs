using SevenZipLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellTester.CollectorsTests
{
	public static class ArchiveEntryExtension
	{
		public static StreamReader ExtractToStreamReader(this ArchiveEntry archiveEntry)
		{
			var stream = new MemoryStream();
			stream.Position = 0;
			archiveEntry.Extract(stream);
			var result = new StreamReader(stream);
			result.BaseStream.Position = 0;
			return result;
		}
	}
}

