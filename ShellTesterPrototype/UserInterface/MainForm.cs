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
using UserInterface.Model;
using UserInterface.MongoDb;

namespace UserInterface
{
	public partial class MainForm : Form
	{

		private readonly IPlatformLogger _logger;
		private readonly ICompleteTestResultRepository _repository;
		private IConfigTestsetProvider _lastRunConfig = null;
		private ICollectorTests _lastCollectorTests = null;

		public MainForm(IPlatformLogger logger, ICompleteTestResultRepository repository)
		{
			InitializeComponent();
			_logger = logger;
			_repository = repository;
		}

		private void ChoicePathDialog(TextBox textBox)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();

			openFileDialog.InitialDirectory = textBox.Text.Length > 0 ? textBox.Text : "c:\\";

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				var selectedFileName = openFileDialog.FileName;
				textBox.Text = selectedFileName;
			}
		}

		private void ChoiceTestsetButton_Click(Object sender, EventArgs e)
		{
			ChoicePathDialog(PathToTestsetBox);
			UpdateCollector();

		}


		private void UpdateCollector()
		{
			_lastCollectorTests = new ZipCollectorTests(
					_logger,
					PathToTestsetBox.Text,
					new String[] { "228", "123" }

				);

			_lastRunConfig = _lastCollectorTests.Config;

            MemorylimitBox.Text = _lastRunConfig.DefaultMemoryLimit_mb.ToString();
            TimelimitBox.Text = _lastRunConfig.DefaultTimeLimit_ms.ToString();

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
			
			ITester tester = new Tester(
				logger,
				_lastCollectorTests,
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
			var archiveName = Path.GetFileNameWithoutExtension(PathToTestsetBox.Text);

			choiceTryBox.Items.Add(new TestsetRunResult(
				$"{DateTime.Now.ToString()} Task: {archiveName} Memory: {MemorylimitBox.Text} Time: {TimelimitBox.Text}"+
				$"Result: {result.StringResult()}",
				archiveName,
				_lastRunConfig.TestsetVersion,
				_lastRunConfig.Key,
				result
			));

			choiceTryBox.SelectedIndex = choiceTryBox.Items.Count-1;

		}

		private void ChoiceTryBox_SelectedIndexChanged(Object sender, EventArgs e)
		{
			var selected = choiceTryBox.SelectedItem as TestsetRunResult;
			ResultTestRunBox.Text = selected.Result.StringResult();


			var source = new BindingSource
			{
				DataSource = selected.Result.Select(x => new TestResulUserView()
				{
					Id = x.Id,
					Kind = x.Kind,
					Time_ms = x.ExecutionTime_ms,
					Memory_mb = x.PeekMemory_mb,
					Price = x.Price,
					TimeLimit_ms = _lastRunConfig.TimeLimitFor(x.Id),
					MemoryLimit_mb = _lastRunConfig.MemoryLimitFor(x.Id)
				})

			};

			testResultDataGridView.DataSource = source;
			percentageBox.Text = $"{selected.Result.PercentageResult().ToString()}%";
		}


		private class TestResulUserView
		{
			public String Id { get; set; }
			public TestResultKind Kind { get; set; }
			public Int64 Time_ms { get; set; }
			public Int64 Memory_mb { get; set; }
			public Int64 Price { get; set; }
			public Int64 TimeLimit_ms { get; set; }
			public Int64 MemoryLimit_mb { get; set; }
			
		}

		private void SendResultButton_Click(Object sender, EventArgs e)
		{
			var selected = choiceTryBox.SelectedItem as TestsetRunResult;
			var SendForm = new SendForm(
				_logger,
				_repository,
				selected
			);
			SendForm.Show();
		}
	}
}
