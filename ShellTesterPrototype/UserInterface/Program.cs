using Logger;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			using (var logger = new StreamLogger(new StreamWriter(DateTime.Now.Date.ToString("dd/MM/yyyy") + ".log") { AutoFlush = true }))
			{
				
				Application.Run(new MainForm(logger));
			}
		}
	}
}
