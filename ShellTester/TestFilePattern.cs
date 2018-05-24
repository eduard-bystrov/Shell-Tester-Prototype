using System;

namespace ShellTester
{
	public class TestFilePattern : ITestFilePattern
	{
		public TestFilePattern(String pattern)
		{
			String[] splits = pattern.Split(SEPARATORS);

			if (splits.Length != 7) throw new NotImplementedException();

			PrefixPattern = splits[1];
			NumberPattern = splits[3];
			SuffixPattern = splits[5];
		}

		public TestFilePattern(String prefix, String number, String suffix)
		{
			PrefixPattern = prefix;
			NumberPattern = number;
			SuffixPattern = suffix;
		}

		public String Pattern
		{
			get
			{
				return WrapBracket(PrefixPattern) +
					   WrapBracket(NumberPattern) +
					   WrapBracket(SuffixPattern);
			}
		}

		public String PrefixPattern { get; private set; }
		public String NumberPattern { get; private set; }
		public String SuffixPattern { get; private set; }

		private String WrapBracket(String s)
		{
			return '(' + s + ')';
		}

		private static readonly Char[] SEPARATORS = { '(', ')' };
	}
}