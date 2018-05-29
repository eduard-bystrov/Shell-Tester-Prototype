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
	public partial class ResultTestsForm : Form
	{
		public ResultTestsForm(IList<TestResult> testResults)
		{
			InitializeComponent();
			testResults = _testResults;
		}


		private readonly IList<TestResult> _testResults;
	}
}
