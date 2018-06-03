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
using UserInterface.Extension;
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

			choiceTryBox.Items.Add(new OneTestRunnerResult(
				$"{DateTime.Now.ToString()} {Path.GetFileNameWithoutExtension(PathToTestsetBox.Text)} Memory:{MemorylimitBox.Text} Time: {TimelimitBox.Text}"+
				$"{result.StringResult()}",
				result
			));

			choiceTryBox.SelectedIndex = choiceTryBox.Items.Count-1;


		}

		private void ChoiceTryBox_SelectedIndexChanged(Object sender, EventArgs e)
		{
			var selected = choiceTryBox.SelectedItem as OneTestRunnerResult;
			ResultTestRunBox.Text = selected.Result.StringResult();
		}

		private class OneTestRunnerResult
		{
			public String Name { get; private set; }
			public List<TestResult> Result { get; private set; }

			public OneTestRunnerResult(String name, List<TestResult> results)
			{
				Name = name;
				Result = results;
			}


			public override String ToString()
			{
				return Name;
			}
		}

		private void SendResultButton_Click(Object sender, EventArgs e)
		{
			var selected = choiceTryBox.SelectedItem as OneTestRunnerResult;
			var SendForm = new SendForm(_logger, _repository, selected.Result);
			SendForm.Show();
		}

		
	}
}
