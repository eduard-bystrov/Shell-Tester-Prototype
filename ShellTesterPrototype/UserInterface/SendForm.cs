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
using UserInterface.Model;
using UserInterface.MongoDb;

namespace UserInterface
{
	public partial class SendForm : Form
	{
		private readonly TestsetRunResult _runResult;
		private readonly IPlatformLogger _logger;
		private readonly ICompleteTestResultRepository _repository;


		public SendForm(
			IPlatformLogger logger, 
			ICompleteTestResultRepository repository, 
			TestsetRunResult runResult
		)
		{
			InitializeComponent();

			_runResult = runResult;
			_logger = logger;
			_repository = repository;

			var testResults = _runResult.Result;

			InitYearBox();
			this.testResultBox.Text = $"{testResults.Count(x => x.Kind == TestResultKind.Success)}/{testResults.Count}";
			this.semesterBox.Text = DateTime.Now.Month >= 9 ? "Осенний" : "Весенний";
			this.scoreBox.Text = $"{testResults.PercentageResult()}%";
			this.subjectTaskBox.Text = _runResult.ArchiveName;
		}

		void InitYearBox()
		{
			var currentYear = DateTime.Now.Year;

			List<int> years = new List<int>();

			for (int i = 0; i < 10; ++i)
			{
				years.Add(currentYear - i);
			}

			this.yearsBox.DataSource = years;
			this.yearsBox.DropDownStyle = ComboBoxStyle.DropDownList;
			this.yearsBox.SelectedIndex = 0;
		}

		//TODO пустой email
		private void SendButton_Click(Object sender, EventArgs e)
		{

			using (var authForm = new TeacherAuthorizationForm(_runResult.Key))
			{
				if (authForm.ShowDialog() == DialogResult.OK)
				{
					String resultMessageBox;

					if (mailBox.Text.IsValidEmail())
					{
						SendToMail();
						resultMessageBox = $"Авторизация пройдена, результаты отправлены на почту {mailBox.Text}";

						if (dbCheckBox.Enabled)
						{
							SendToDb();
							resultMessageBox += " и в базу данных";
						}
					}
					else
					{
						resultMessageBox = $"Неверный формат email: {mailBox.Text}\n";

						if (dbCheckBox.Enabled)
						{
							SendToDb();
							resultMessageBox += "Результаты отправлены в базу данных";
						}

					}

					MessageBox.Show(resultMessageBox);
				}
				else
				{
					MessageBox.Show($"Неверный логин/пароль");
				}

			}

		}

		private void SendToDb()
		{
			_repository.AddTestResult(CompleteTestResult).Wait();
		}

		private CompleteTestResult CompleteTestResult
		{
			get
			{
				return new CompleteTestResult()
				{
					Student = new Student
					{
						FullName = fullnameBox.Text,
						Group = groupBox.Text,
						Year = yearsBox.Text,
						Semester = semesterBox.Text,
					},

					//TODO TestSetVersion
					Work = new Work
					{
						SubjectName = subjectNameBox.Text,
						TaskName = subjectTaskBox.Text,
						TestVesion = _runResult.TestsetVersion
					},

					Extra = extraBox.Text,
					Score = scoreBox.Text,
					TestResult = _runResult.Result,
				};
			} 
		}

		private void SendToMail()
		{
			

			IPostman postman = new GmailPostman(_logger, "testersfedu@gmail.com", "123456vkr^^", "TesterSfedu");

			postman.Send(
				mailBox.Text,
				$"{fullnameBox.Text}_{groupBox.Text}_{yearsBox.Text}_{semesterBox.Text}_{subjectNameBox.Text}",
				_runResult.Result,
				MakePrefix
			);
		}

		private String MakePrefix
		{
			get
			{
				StringBuilder stringBuilder = new StringBuilder();

				stringBuilder.AppendHtmlText($"Дата : {DateTime.Now.ToString()}");
				stringBuilder.AppendHtmlText($"{fullnameLabel.Text} : {fullnameBox.Text}");
				stringBuilder.AppendHtmlText($"{groupLabel.Text} : {groupBox.Text}");
				stringBuilder.AppendHtmlText($"{yearsLabel.Text} : {yearsBox.Text}");
				stringBuilder.AppendHtmlText($"{semesterLabel.Text} : {semesterBox.Text}");
				stringBuilder.AppendHtmlText($"{testResultLabel.Text} : {testResultBox.Text}");
				stringBuilder.AppendHtmlText($"{scoreLabel.Text} : {scoreBox.Text}");
				stringBuilder.AppendHtmlText($"{extraLabel.Text} : {extraBox.Text}");
				stringBuilder.AppendHtmlText($"{subjectNameLabel.Text} : {subjectNameBox.Text}");
				stringBuilder.AppendHtmlText($"{subjectTaskLabel.Text} : {subjectTaskBox.Text}");
				stringBuilder.AppendHtmlText($"Версия пакета : {_runResult.TestsetVersion}");

				return stringBuilder.ToString();
			}
		}
	
	}
}
