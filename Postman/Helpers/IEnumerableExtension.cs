using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postman.Helpers
{
	public static class IEnumerableExtension<T>
	{
		public static String CreateHtmlTable(IEnumerable<T> list,  IEnumerable<Func<T, Object>> fxns)
		{

			StringBuilder sb = new StringBuilder();
			sb.Append("<TABLE>\n");
			foreach (var item in list)
			{
				sb.Append("<TR>\n");
				foreach (var fxn in fxns)
				{
					sb.Append("<TD>");
					sb.Append(fxn(item));
					sb.Append("</TD>");
				}
				sb.Append("</TR>\n");
			}
			sb.Append("</TABLE>");

			return sb.ToString();
		}
	}
}
