using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Postman.Helpers;
using ShellTester;

namespace Postman
{
	public class BasePostman : IPostman
	{
		public BasePostman(
			String email,
			String password,
			String name,
			String smptpAdress,
			Int32 port

		)
		{
			SmtpClient = new SmtpClient(smptpAdress, port)
			{
				Credentials = new NetworkCredential(email, password),
				EnableSsl = true
			};

			From = new MailAddress(email, name);

			_funcs = new List<Func<TestResult, Object>>();
			_funcs.Add(x => x.Id);
			_funcs.Add(x => x.Description);
			_funcs.Add(x => x.Type);
			_funcs.Add(x => x.ExecutionTime);
			_funcs.Add(x => x.PeekMemory);
		}

		
		public void Send(
			String email, 
			String subject,
			IEnumerable<TestResult> testResults
		)
		{
			MailAddress to = new MailAddress(email);
			MailMessage message = new MailMessage(From, to)
			{
				Subject = subject,
				Body = IEnumerableExtension<TestResult>.
				CreateHtmlTable(
				testResults, _funcs),
				IsBodyHtml = true
				
			};


			SmtpClient.Send(message);

		}

		public Boolean TrySend(
			String email,
			String subject,
			IEnumerable<TestResult> testResults)
		{
			throw new NotImplementedException();
		}



		protected MailAddress From { get; set; }
		protected SmtpClient SmtpClient { get; set; }

		protected List<Func<TestResult, Object>> _funcs;
	}
}
