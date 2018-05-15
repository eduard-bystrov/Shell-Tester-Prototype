using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
	public interface IPlatformLogger
	{
		/// <summary>
		/// Записывает сообщение
		/// </summary>
		/// <param name="message">Сообщение</param>
		/// <param name="category">Категория сообщения</param>
		/// <param name="priority">Приоритет сообщения</param>
		/// <param name="args">Параметры</param>
		void Write(LogCategory category, LogPriority priority, String message, params Object[] args);

		/// <summary>
		/// Записывает сообщение
		/// </summary>
		/// <param name="message">Сообщение</param>
		/// <param name="category">Категория сообщения</param>
		/// <param name="priority">Приоритет сообщения</param>
		/// <param name="args">Параметры</param>
		/// <param name="system">Признак сообщения, имеющего значение для системы в целом</param>
		void Write(LogCategory category, LogPriority priority, Boolean system, String message, params Object[] args);

		/// <summary>
		/// Определяет включен ли логгер
		/// </summary>
		Boolean IsEnable { get; }

		/// <summary>
		/// Возвращает минимальную установленую категорию
		/// </summary>
		LogPriority MinPriority { get; }
	}
}
