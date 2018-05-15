using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using ShellTester;

namespace Postman
{
	public class YandexPostman : BasePostman
	{
		public YandexPostman(
			String email,
			String password,
			String name
		)
			:base(email, password, name, _smptpAdress, _port)
		{
			
		}
		
		private static readonly String _smptpAdress = "smtp.yandex.ru";
		private static readonly Int32 _port = 25;
	}
}
