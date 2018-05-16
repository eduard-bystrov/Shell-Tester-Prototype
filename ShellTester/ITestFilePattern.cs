using System;

namespace ShellTester
{
	public interface ITestFilePattern
	{
		String PrefixPattern { get; }
		String NumberPattern { get; }
		String SuffixPattern { get; }
	}
}