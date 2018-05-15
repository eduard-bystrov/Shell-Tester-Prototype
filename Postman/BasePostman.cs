using Postman.Helpers;
using ShellTester;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Net;
using System.Net.Mail;

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
				EnableSsl = true,
				//DeliveryMethod = SmtpDeliveryMethod.Network,
				//UseDefaultCredentials = false
			};

			From = new MailAddress(email, name);

			_funcs = new List<Expression<Func<TestResult, Object>>>
			{

				//TODO тоже в рефлекшн
				x => x.Id,
				x => x.Description,
				x => x.Type,
				x => x.ExecutionTime,
				x => x.PeekMemory
			};
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
				IsBodyHtml = true,
			};

			SmtpClient.Send(message);
		}

		public Boolean TrySend(
			String email,
			String subject,
			IEnumerable<TestResult> testResults)
		{
			Boolean result = true;

			try
			{
				Send(email, subject, testResults);
			}
			catch (Exception ex)
			{
				result = false;
			}

			return result;
		}

		protected MailAddress From { get; set; }
		protected SmtpClient SmtpClient { get; set; }

		protected IList<Expression<Func<TestResult, Object>>> _funcs;
	}
}