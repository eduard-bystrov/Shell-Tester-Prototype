using Logger;
using System;

namespace Postman
{
	public class GmailPostman : BasePostman
	{
		public GmailPostman(
			IPlatformLogger logger,
			String email,
			String password,
			String name
		)
		: base(logger, email, password, name, _smtpAdress, _port)
		{
		}

		private static readonly String _smtpAdress = @"smtp.gmail.com";
		private static readonly Int32 _port = 25;
	}
}