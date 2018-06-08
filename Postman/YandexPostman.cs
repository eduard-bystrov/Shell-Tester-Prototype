using Logger;
using System;

namespace Postman
{
	public class YandexPostman : BasePostman
	{
		public YandexPostman(
			IPlatformLogger logger,
			String email,
			String password,
			String name
		)
			: base(logger, email, password, name, _smtpAdress, _port)
		{
		}

		private static readonly String _smtpAdress = "smtp.yandex.ru";
		private static readonly Int32 _port = 25;
	}
}