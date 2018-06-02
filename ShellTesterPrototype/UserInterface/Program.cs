using Logger;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserInterface.Model;
using UserInterface.MongoDb;

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
				
				Application.Run(new MainForm(
					logger, 
					new CompleteTestResultRepository(
						logger,
						Options.Create<DbSettings>(
							new DbSettings
							{
								ConnectionString = Properties.Settings.Default.ConnectionString,
								Database = Properties.Settings.Default.Database
							}
						)
					)
				));
			}
		}
	}
}
