using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;
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

		[BsonId(IdGenerator = typeof(StringObjectIdGenerator))]
		public string Id { get; set; }
		public DateTime UpdatedOn { get; set; } = DateTime.Now;
		public DateTime CreatedOn { get; set; } = DateTime.Now;

		public Student Student { get; set; }
		public Work Work { get; set; }
		public String Score { get; set; }
		public String Extra { get; set; }
		public List<TestResult> TestResult { get; set; }
	}


	public class Student
	{
		public String FullName { get; set; }
		public String Group { get; set; }
		public String Year { get; set; }
		public String Semester { get; set; }
	}	
	
	public class Work
	{
		public String SubjectName { get; set; }
		public String TaskName { get; set; }
		public String TestVesion { get; set; }
	}
}
