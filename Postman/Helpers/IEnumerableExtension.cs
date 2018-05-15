using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;

namespace Postman.Helpers
{
	public static class IEnumerableExtension<T>
	{
		public static String CreateHtmlTable<T>(IEnumerable<T> list, IEnumerable<Expression<Func<T, Object>>> fxns)
		{
			StringBuilder sb = new StringBuilder();
			sb.Append("<TABLE>\n");

			sb.Append("<TR>\n");
			foreach (var fxn in fxns)
			{
				sb.Append("<TD>");
				sb.Append(GetName(fxn));
				sb.Append("</TD>");
			}
			sb.Append("</TR> <!-- HEADER -->\n");

			foreach (var item in list)
			{
				sb.Append("<TR>\n");
				foreach (var fxn in fxns)
				{
					sb.Append("<TD>");
					sb.Append(fxn.Compile()(item));
					sb.Append("</TD>");
				}
				sb.Append("</TR>\n");
			}
			sb.Append("</TABLE>");

			return sb.ToString();
		}

		private static String GetName<T>(Expression<Func<T, Object>> expr)
		{
			var member = expr.Body as MemberExpression;
			if (member != null)
				return GetNameReflection(member);

			var unary = expr.Body as UnaryExpression;
			if (unary != null)
				return GetNameReflection((MemberExpression)unary.Operand);

			return "?+?";
		}

		private static String GetNameReflection(MemberExpression member)
		{
			var fieldInfo = member.Member as FieldInfo;
			if (fieldInfo != null)
			{
				var attr = fieldInfo.GetCustomAttribute(typeof(DescriptionAttribute)) as DescriptionAttribute;
				if (attr != null) return attr.Description;
				return fieldInfo.Name;
			}

			var propertInfo = member.Member as PropertyInfo;
			if (propertInfo != null)
			{
				var attr = propertInfo.GetCustomAttribute(typeof(DescriptionAttribute)) as DescriptionAttribute;
				if (attr != null) return attr.Description;
				return propertInfo.Name;
			}

			return "?-?";
		}
	}
}