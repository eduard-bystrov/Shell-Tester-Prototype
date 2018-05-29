using ShellTester;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
	public partial class TeacherAuthorizationForm : Form
	{
		public TeacherAuthorizationForm()
		{
			InitializeComponent();
			
		}

		private void SendButton_Click(Object sender, EventArgs e)
		{
			var login = loginBox.Text;
			var pass = passwordBox.Text;

			if (login == "admin" && pass == "admin")
			{
				this.DialogResult = DialogResult.OK;
				
			}
			else
			{
				this.DialogResult = DialogResult.Cancel;
			}

			this.Close();
		}
	}
}
