using System;

namespace ShellTester
{
	public class TestFilePattern : ITestFilePattern
	{
		// можно ли сделать так что гет метод вернет собранный паттерн

		public TestFilePattern(String pattern)
		{
			// пытался сделать регулярку, но не пошло ))00000
			String[] splits = pattern.Split(SEPARATORS);

			if (splits.Length != 7) throw new NotImplementedException();

			_prefixPattern = splits[1];
			_numberPattern = splits[3];
			_suffixPattern = splits[5];
		}

		public TestFilePattern(String prefix, String number, String suffix)
		{
			_prefixPattern = prefix;
			_numberPattern = number;
			_suffixPattern = suffix;
		}

		public String GetPattern
		{
			get
			{
				return WrapBracket(_prefixPattern) +
					   WrapBracket(_numberPattern) +
					   WrapBracket(_suffixPattern);
			}
		}

		public String _prefixPattern { get; private set; }
		public String _numberPattern { get; private set; }
		public String _suffixPattern { get; private set; }

		private String WrapBracket(String s)
		{
			return '(' + s + ')';
		}

		private static readonly Char[] SEPARATORS = { '(', ')' };
	}
}