using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellTester
{
	public interface IStreamComparer
	{
		Boolean Equal(StreamReader lsh, StreamReader rsh);
	}
}
