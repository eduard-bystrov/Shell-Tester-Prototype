﻿using System;

namespace Postman
{
	public class GmailPostman : BasePostman
	{
		public GmailPostman(
		String email,
		String password,
		String name
		)
		: base(email, password, name, _smptpAdress, _port)
		{
		}

		private static readonly String _smptpAdress = @"smtp.gmail.com";
		private static readonly Int32 _port = 25;
	}
}