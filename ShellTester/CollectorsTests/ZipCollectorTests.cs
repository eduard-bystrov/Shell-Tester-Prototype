using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logger;

namespace ShellTester.CollectorsTests
{
	public class ZipCollectorTests : AbstractCollectorTests
	{
		public ZipCollectorTests(
			IPlatformLogger logger,
			String workPath,
			TestFilePattern inputFilePattern,
			TestFilePattern outputFilePatten
		) 
			: base(logger, workPath, inputFilePattern, outputFilePatten)
		{
		}

		public IEnumerable<Test> MakeTestBlocks()
		{
			throw new NotImplementedException();
		}
	}
}
