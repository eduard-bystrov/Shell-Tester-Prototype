using System.Collections.Generic;

namespace ShellTester
{
	public interface ITester
	{
		IEnumerable<TestResult> Run();
	}
}