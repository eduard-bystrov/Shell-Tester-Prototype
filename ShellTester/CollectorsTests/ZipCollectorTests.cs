using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

		public IEnumerable<Test> MakeTestBlocks()
		{
			//TODO без пароля
			//TODO пароли
		}


		private readonly IEnumerable<String> _passwords;
	}
}
