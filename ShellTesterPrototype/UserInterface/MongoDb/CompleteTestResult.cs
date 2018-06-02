using MongoDB.Bson.Serialization.Attributes;
using ShellTester;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterface.MongoDb
{
	public class CompleteTestResult
	{
		public String FullName { get; set; }
		public String Group { get; set; }
		public String Year { get; set; }
		public String Semester { get; set; }
		public String Extra { get; set; }
		public String Score { get; set; }
		public String SubjectName { get; set; }
		public String TaskName { get; set; }

		public List<TestResult> TestResult { get; set; }


		[BsonId]
		public string Id { get; set; }
		public DateTime UpdatedOn { get; set; } = DateTime.Now;
		public DateTime CreatedOn { get; set; } = DateTime.Now;
	}
}
