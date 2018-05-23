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
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(Object sender, EventArgs e)
		{

		}

		private void PersonalData_Enter(Object sender, EventArgs e)
		{

		}

		private void NameLabel_Click(Object sender, EventArgs e)
		{

		}

		private void SurnameLable_Click(Object sender, EventArgs e)
		{

		}

		private void MenuStrip_ItemClicked(Object sender, ToolStripItemClickedEventArgs e)
		{

		}

		private void ChoicePathToTestsetButton_Click(Object sender, EventArgs e)
		{
			ChoicePathDialog(choicePathToTestsetBox);
		}

		private void ChoicePathToProgramButton_Click(Object sender, EventArgs e)
		{
			
			OpenFileDialog openFileDialog = new OpenFileDialog();

			openFileDialog.InitialDirectory = "c:\\";
			openFileDialog.Filter = "Exe Files (.exe)|*.exe|All Files (*.*)|*.*";
			openFileDialog.FilterIndex = 1;
			openFileDialog.RestoreDirectory = true;

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				var selectedFileName = openFileDialog.FileName;
				choicePathToProgramBox.Text = selectedFileName;
			}
			
		}



		private void ChoicePathDialog(TextBox textBox)
		{
			var folderBrowserDialog = new FolderBrowserDialog();

			if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
			{
				var path = folderBrowserDialog.SelectedPath;
				textBox.Text = path;
			}
		}

		private void SettingsToolStripMenuItem_Click(Object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellContentClick(Object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
