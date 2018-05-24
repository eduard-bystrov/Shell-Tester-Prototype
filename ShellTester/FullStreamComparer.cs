	using System;
	using System.Collections.Generic;
	using System.IO;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	namespace ShellTester
	{
		public class FullStreamComparer : IEqualityComparer<StreamReader>
		{
			public Boolean Equals(StreamReader lsh, StreamReader rsh)
			{
				if (lsh == null && rsh == null) return true;
				if (lsh == null || rsh == null) return false;

				String lshString = lsh.ReadToEnd();
				String rshString = rsh.ReadToEnd();

				return lshString == rshString;
			}


			public Int32 GetHashCode(StreamReader obj)
			{
				return obj.GetHashCode();
			}
		}
	}
