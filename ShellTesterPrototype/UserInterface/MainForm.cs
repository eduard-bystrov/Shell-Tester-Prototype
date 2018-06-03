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
using UserInterface.MongoDb;

namespace UserInterface
{
	public partial class MainForm : Form
	{

		private readonly IPlatformLogger _logger;
		private readonly ICompleteTestResultRepository _repository;

		public MainForm(IPlatformLogger logger, ICompleteTestResultRepository repository)
		{
			InitializeComponent();
			_logger = logger;
			_repository = repository;
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


		private List<TestResult> RunTester(IPlatformLogger logger)
		{
			

			String inMask = @"(input)(\d+)(.txt)";
			String outMask = @"(output)(\d+)(.txt)";

			ITester tester = new Tester(
				logger,
				new ZipCollectorTests(
					logger,
					new DefaultConfigTestsetSettings(),
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


			var results = new List<TestResult>(tester.Run());

			return results;
			
		}

		private void StartTestingButton_Click(Object sender, EventArgs e)
		{
			
			var result = RunTester(_logger);
			var SendForm = new SendForm(_logger,_repository, result);
			SendForm.Show();

			choiceTryBox.Items.Add(new OneTestRunnerResult(
				$"",
				result
			));
			
		}

		private void ChoiceTryBox_SelectedIndexChanged(Object sender, EventArgs e)
		{

		}

		private class OneTestRunnerResult
		{
			private readonly String _name;
			private readonly List<TestResult> _results;

			public OneTestRunnerResult(String name, List<TestResult> results)
			{
				_name = name;
				_results = results;
			}


			public override String ToString()
			{
				return _name;
			}
		}
	}
}
