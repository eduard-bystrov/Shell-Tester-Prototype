using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterface.Extension
{
	public static class StringBuilderExtension
	{
		public static void AppendEndLine(this StringBuilder stringBuilder, String text)
		{
			stringBuilder.Append(text + "\n");
		}


		public static void AppendHtmlText(this StringBuilder stringBuilder, String text)
		{
			stringBuilder.Append($"<p>{text}</p>\n");
		}
	}
}
