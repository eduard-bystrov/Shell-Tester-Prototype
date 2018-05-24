using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Postman;
using ShellTester;

namespace UnitTestset
{
	[TestClass]
	public class PostmanTestset : BaseTestset
	{
		[TestMethod]
		public void EmptyMessage()
		{
			IPostman postman = new GmailPostman(Logger, "testersfedu@gmail.com", "123456vkr^^", "TesterSfedu");
			postman.Send("eipii0@yandex.ru","title", Enumerable.Empty<ShellTester.TestResult>());
			
		}

		[TestMethod]
		[ExpectedException(typeof(FormatException))]
		public void WrongEmail()
		{
			IPostman postman = new GmailPostman(Logger, "testersfedu@gmail.com", "123456vkr^^", "TesterSfedu");
			postman.Send("eipii0yandex.ru", "title", Enumerable.Empty<ShellTester.TestResult>());

		}

		[TestMethod]
		public void CorrectSend()
		{
			IPostman postman = new GmailPostman(Logger, "testersfedu@gmail.com", "123456vkr^^", "TesterSfedu");
			postman.Send("eipii0@yandex.ru", "title", CreateSimpleTestResult());
		}

		[TestMethod]
		[ExpectedException(typeof(NullReferenceException))]
		public void NullMessage()
		{
			IPostman postman = new GmailPostman(Logger, "testersfedu@gmail.com", "123456vkr^^", "TesterSfedu");
			postman.Send("eipii0@yandex.ru", "title", null);
		}
	}
}
