using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ShellTester
{
	public static class TestFilePatternExtension
	{
		public static String GetNumberPart(this TestFilePattern pattern, String name)
		{
			var preffixMatches = pattern.GetPreffixRegex().Matches(name);
			var suffixMatches = pattern.GetSuffixRegex().Matches(name);

			if (preffixMatches.Count > 1 || suffixMatches.Count > 1)
			{
				throw new Exception($"String: {name} have more than one preffix or suffix part");
			}

			var firstPreffix = preffixMatches.Cast<Match>().First();
			var firstSuffix = suffixMatches.Cast<Match>().First();

			var leftPos = firstPreffix.Index + firstPreffix.Length;
			var rightPos = firstSuffix.Index;

			var number = name.Substring(leftPos, rightPos - leftPos);
			var numberMatches = pattern.GetNumberRegex().Matches(name);

			if (numberMatches.Count > 1 || numberMatches.Count == 0)
			{
				throw new Exception($"String: {name} have more than bad number part: {number}");
			}

			return number;

		}

		public static Regex GetFullRegex(this TestFilePattern pattern)
		{
			return new Regex(pattern.Pattern);
		}

		public static Regex GetPreffixRegex(this TestFilePattern pattern)
		{
			return new Regex(pattern.PrefixPattern);
		}

		public static Regex GetNumberRegex(this TestFilePattern pattern)
		{
			return new Regex(pattern.NumberPattern);
		}

		public static Regex GetSuffixRegex(this TestFilePattern pattern)
		{
			return new Regex(pattern.SuffixPattern);
		}
	}
}
