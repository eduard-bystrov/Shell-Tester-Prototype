using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
	public enum LogCategory : byte
	{
		/// <summary>
		/// Информация отладночного характера
		/// </summary>
		Debug = 0,
		/// <summary>
		/// Информация о произощедшей ошибке
		/// </summary>
		Error = 1,
		/// <summary>
		/// Предупреждение
		/// </summary>
		Warn = 2,
		/// <summary>
		/// Информационное сообщение
		/// </summary>
		Info = 3,
	}
}
