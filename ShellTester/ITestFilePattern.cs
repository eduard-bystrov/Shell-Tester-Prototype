using System;

namespace ShellTester
{
	public interface ITestFilePattern
	{
		String _prefixPattern { get; }
		String _numberPattern { get; }
		String _suffixPattern { get; }
	}
}