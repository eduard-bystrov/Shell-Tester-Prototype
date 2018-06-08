using Logger;
using Logger.Enhanced;
using Postman.Helpers;
using ShellTester;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Mail;

namespace Postman
{
	public class BasePostman : IPostman
	{
		public BasePostman(
			IPlatformLogger logger,
			String email,
			String password,
			String name,
			String smtpAdress,
			Int32 port

		)
		{

			Logger = logger;

			SmtpClient = new SmtpClient(smtpAdress, port)
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
				x => x.Kind,
				x => x.ExecutionTime,
				x => x.PeekMemory_bit
			};
		}

		public void Send(
			String email,
			String subject,
			IEnumerable<TestResult> testResults,
			String prefixText = null
		)
		{
			MailAddress to = new MailAddress(email);
			MailMessage message = new MailMessage(From, to)
			{
				Subject = subject,
				Body = 
					(prefixText is null ? "" : prefixText) + 
					CSharpObjectToHtmlTableConverter.CreateHtmlTable<TestResult>(
							testResults,
							_funcs),
				
				IsBodyHtml = true,
			};

			SmtpClient.Send(message);
		}

		public Boolean TrySend(
			String email,
			String subject,
			IEnumerable<TestResult> testResults,
			String prefixText = null
		)
		{
			Boolean result = true;

			try
			{
				Send(email, subject, testResults, prefixText);
			}
			catch (Exception ex)
			{
				Logger.Warn($"Exception on send message: {ex.ToString()}");
				result = false;
			}

			return result;
		}

		protected MailAddress From { get; set; }
		protected SmtpClient SmtpClient { get; set; }
		protected IPlatformLogger Logger { get; }

		protected IList<Expression<Func<TestResult, Object>>> _funcs;
	}
}