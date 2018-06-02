using MongoDB.Bson;
using MongoDB.Driver;
using ShellTester;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterface.MongoDb
{
	public interface ICompleteTestResultRepository
	{
		Task<IEnumerable<CompleteTestResult>> GetAllTestResults();
		Task<CompleteTestResult> GetTestResult(String id);
		Task AddTestResult(CompleteTestResult item);
		Task<DeleteResult> RemoveTestResult(String id);

		Task<UpdateResult> UpdateTestResult(String id, CompleteTestResult newResult);


		Task<DeleteResult> RemoveAllTestResult();

		Task<String> GetFileInfo(String id);
	}
}
