using Logger;
using Postman;
using ShellTester;
using ShellTester.CollectorsTests;
using ShellTester.ConfigProviders;
using ShellTester.Launchers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

		private void ChoicePathDialog(TextBox textBox)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();

			openFileDialog.InitialDirectory = textBox.Text.Length > 0 ? textBox.Text  : "c:\\";

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				var selectedFileName = openFileDialog.FileName;
				textBox.Text = selectedFileName;
			}
		}

		private void ChoiceTestsetButton_Click(Object sender, EventArgs e)
		{
			ChoicePathDialog(PathToTestsetBox);
		}

		private void ChoicePathToProgramButton_Click(Object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();

			openFileDialog.InitialDirectory = PathToProgramBox.Text.Length > 0 ? PathToProgramBox.Text : "c:\\";
			openFileDialog.Filter = "Exe Files (.exe)|*.exe|All Files (*.*)|*.*";
			openFileDialog.FilterIndex = 1;
			openFileDialog.RestoreDirectory = true;

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				var selectedFileName = openFileDialog.FileName;
				PathToProgramBox.Text = selectedFileName;
			}
		}

		private void StartTestingButton_Click(Object sender, EventArgs e)
		{
			using (var logger = new StreamLogger(new StreamWriter(DateTime.Now.Date.ToString("dd/MM/yyyy") + ".log") { AutoFlush = true }))
			{

				String inMask = @"(input)(\d+)(.txt)";
				String outMask = @"(output)(\d+)(.txt)";

				ITester tester = new Tester(
					logger,
					new ZipCollectorTests(
						logger,
						new DefaultConfigTestsetProvider(),
						PathToTestsetBox.Text,
						new TestFilePattern(inMask),
						new TestFilePattern(outMask),
						new String[] { "228", "123" }

					),
					new CheckAllTestsLauncher
						(
							new OneTestRunner(
								logger,
								new FullStreamComparer(),
								PathToProgramBox.Text
							)
						)
				);

				var result = tester.Run();

				List<TestResult> l = new List<TestResult>(result);

				IPostman postman = new GmailPostman(logger, "testersfedu@gmail.com", "123456vkr^^", "TesterSfedu");

				postman.Send("eipii0@yandex.ru", "Test", l);
			}
		}
	}
}
