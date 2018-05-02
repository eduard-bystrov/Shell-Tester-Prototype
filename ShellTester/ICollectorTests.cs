using System.Collections.Generic;

namespace ShellTester
{
	public interface ICollectorTests
	{
		IEnumerable<Test> MakeTestBlocks();
	}
}