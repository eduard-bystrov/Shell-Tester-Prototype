using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ShellTester
{
	public class TestFilePattern
	{
		// можно ли сделать так что гет метод вернет собранный паттерн

		public TestFilePattern(string pattern)
		{
			// пытался сделать регулярку, но не пошло ))00000
			string[] splits = pattern.Split(SEPARATORS);

			if (splits.Length != 7) throw new NotImplementedException();

			_prefixPattern = splits[1];
			_numberPattern = splits[3];
			_suffixPattern = splits[5];
			
		}
		public TestFilePattern(string prefix, string number, string suffix)
		{
			_prefixPattern = prefix;
			_numberPattern = number;
			_suffixPattern = suffix;
		}
		public string GetPattern
		{
			get
			{
				return WrapBracket(_prefixPattern) +
					   WrapBracket(_numberPattern) +
					   WrapBracket(_suffixPattern);
			}
		}
		public string _prefixPattern { get; private set; }
		public string _numberPattern { get; private set; }
		public string _suffixPattern { get; private set; }

		private string WrapBracket(string s)
		{
			return '(' + s + ')';
		}

		private char[] SEPARATORS = { '(', ')' };
	} 
}
