using Logger;
using Postman;
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
using UserInterface.Extension;

namespace UserInterface
{
	public partial class SendForm : Form
	{
		public SendForm(IPlatformLogger logger, IList<TestResult> testResults)
		{
			InitializeComponent();

			_testResults = testResults;
			_logger = logger;

			var currentYear = DateTime.Now.Year;

			List<int> years = new List<int>();

			for (int i = 0; i < 10; ++i)
			{
				years.Add(currentYear - i);
			}

			this.yearsBox.DataSource = years;
			this.yearsBox.DropDownStyle = ComboBoxStyle.DropDownList;
			this.yearsBox.SelectedIndex = 0;

			this.testResultBox.Text = $"{testResults.Count(x => x.Kind == TestResultKind.Success)}/{testResults.Count}";

		}

		private readonly IList<TestResult> _testResults;
		private readonly IPlatformLogger _logger;

		private void textBox5_TextChanged(Object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(Object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(Object sender, EventArgs e)
		{

		}

		private void SendButton_Click(Object sender, EventArgs e)
		{
			IPostman postman = new GmailPostman(_logger, "testersfedu@gmail.com", "123456vkr^^", "TesterSfedu");

			StringBuilder stringBuilder = new StringBuilder();

			stringBuilder.AppendHtmlText($"{fullnameLabel.Text} : {fullnameBox.Text}");
			stringBuilder.AppendHtmlText($"{groupLabel.Text} : {groupBox.Text}");
			stringBuilder.AppendHtmlText($"{yearsLabel.Text} : {yearsBox.Text}");
			stringBuilder.AppendHtmlText($"{semesterLabel.Text} : {semesterBox.Text}");
			stringBuilder.AppendHtmlText($"{testResultLabel.Text} : {testResultBox.Text}");
			stringBuilder.AppendHtmlText($"{scoreLabel.Text} : {scoreBox.Text}");
			stringBuilder.AppendHtmlText($"{extraLabel.Text} : {extraBox.Text}");
			stringBuilder.AppendHtmlText($"{subjectNameLabel.Text} : {subjectNameBox.Text}");
			stringBuilder.AppendHtmlText($"{subjectTaskLabel.Text} : {subjectTaskBox.Text}");
			stringBuilder.AppendHtmlText($"{subjectVariantLabel.Text} : {subjectVariantBox.Text}");


			postman.Send(
				mailBox.Text,
				$"{fullnameBox.Text}_{groupBox.Text}_{yearsBox.Text}_{semesterBox.Text}_{subjectNameBox.Text}",
				_testResults,
				stringBuilder.ToString()
			);


		}


	

		private void nameBox_TextChanged(Object sender, EventArgs e)
		{

		}

		private void surnameLabel_Click(Object sender, EventArgs e)
		{

		}

		private void label1_Click(Object sender, EventArgs e)
		{

		}

		private void extra_Click(Object sender, EventArgs e)
		{

		}
	}
}
