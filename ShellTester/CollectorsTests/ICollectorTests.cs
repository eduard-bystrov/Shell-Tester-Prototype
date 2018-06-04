using ShellTester.ConfigProviders;
using System.Collections.Generic;
using System.IO;

namespace ShellTester.CollectorsTests
{
	public interface ICollectorTests
	{
		IEnumerable<Test> MakeTestBlocks();
		IConfigTestsetProvider Config { get; } 
	}
}