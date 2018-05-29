using ShellTester;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postman
{
	public interface IPostman
	{

		Boolean TrySend(String email, String subject, IEnumerable<TestResult> testResults, String prefixText = null);
		void Send(String email, String subject, IEnumerable<TestResult> testResults, String prefixText = null);
	}
}
