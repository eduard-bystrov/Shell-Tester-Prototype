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
		private readonly String _key;

		public TeacherAuthorizationForm(String key)
		{
			InitializeComponent();
			_key = key;
			
		}

		private void SendButton_Click(Object sender, EventArgs e)
		{
			var key = KeyBox.Text;

			if (_key == key)
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
