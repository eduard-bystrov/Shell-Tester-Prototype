using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logger;
using Logger.Enhanced;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.GridFS;
using ShellTester;
using UserInterface.Model;

namespace UserInterface.MongoDb
{

	//TODO Логирование
	public class CompleteTestResultRepository : ICompleteTestResultRepository
	{

		private readonly CompleteTestResultContext _context = null;
		private readonly IPlatformLogger _logger;

		public CompleteTestResultRepository(
			IPlatformLogger logger,
			IOptions<DbSettings> settings
			)
		{
			_logger = logger;
			_context = new CompleteTestResultContext(settings);
		}


		public async Task<IEnumerable<CompleteTestResult>> GetAllTestResults()
		{
			try
			{
				return await _context.TestResults.Find(_ => true).ToListAsync().ConfigureAwait(false);
			}
			catch (Exception ex)
			{
				_logger.Warn($"Exception in repository {ex.ToString()}");
				throw ex;
			}
		}

		public async Task<CompleteTestResult> GetTestResult(String id)
		{
			var filter = Builders<CompleteTestResult>.Filter.Eq("Id", id);

			try
			{
				return await _context.TestResults
								.Find(filter)
								.FirstOrDefaultAsync().ConfigureAwait(false);
			}
			catch (Exception ex)
			{
				_logger.Warn($"Exception in repository {ex.ToString()}");
				throw ex;
			}
		}

		public async Task AddTestResult(CompleteTestResult item)
		{
			try
			{
				//item.Id = Guid.NewGuid().ToString();
				await _context.TestResults.InsertOneAsync(item).ConfigureAwait(false);
			}
			catch (Exception ex)
			{
				_logger.Warn($"Exception in repository {ex.ToString()}");
				throw ex;
			}
		}

		public async Task<DeleteResult> RemoveTestResult(String id)
		{
			try
			{
				return await _context.TestResults.DeleteOneAsync(
					 Builders<CompleteTestResult>.Filter.Eq("Id", id)).ConfigureAwait(false);
			}
			catch (Exception ex)
			{
				_logger.Warn($"Exception in repository {ex.ToString()}");
				throw ex;
			}
		}

		public async Task<UpdateResult> UpdateTestResult(String id, CompleteTestResult newResult)
		{
			var filter = Builders<CompleteTestResult>.Filter.Eq(s => s.Id, id);
			var update = Builders<CompleteTestResult>.Update
							.Set(s => s,newResult)
							.CurrentDate(s => s.UpdatedOn);
			try
			{
				return await _context.TestResults.UpdateOneAsync(filter, update).ConfigureAwait(false);
			}
			catch (Exception ex)
			{
				_logger.Warn($"Exception in repository {ex.ToString()}");
				throw ex;
			}
		}


		public async Task<String> GetFileInfo(String id)
		{
			GridFSFileInfo info = null;
			var objectId = new ObjectId(id);
			try
			{
				using (var stream = await _context.Bucket.OpenDownloadStreamAsync(objectId))
				{
					info = stream.FileInfo;
				}
				return info.Filename;
			}
			catch (Exception)
			{
				return "Not Found";
			}
		}

		public async Task<DeleteResult> RemoveAllTestResult()
		{
			try
			{
				return await _context.TestResults.DeleteManyAsync(new BsonDocument());
			}
			catch (Exception ex)
			{
				_logger.Warn($"Exception in repository {ex.ToString()}");
				throw ex;
			}
		}
	}
}
