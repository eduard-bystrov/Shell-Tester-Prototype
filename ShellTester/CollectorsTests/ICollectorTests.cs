using System.Collections.Generic;

namespace ShellTester.CollectorsTests
{
	public interface ICollectorTests
	{
		IEnumerable<Test> MakeTestBlocks();
	}
}