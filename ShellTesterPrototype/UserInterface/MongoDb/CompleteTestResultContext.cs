using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoDB.Driver.GridFS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInterface.Model;

namespace UserInterface.MongoDb
{
	public class CompleteTestResultContext
	{
		private readonly IMongoDatabase _database = null;
		private readonly GridFSBucket _bucket = null;

		public CompleteTestResultContext(IOptions<DbSettings> settings)
		{
			var client = new MongoClient(settings.Value.ConnectionString);
			if (client != null)
			{
				_database = client.GetDatabase(settings.Value.Database);

				var gridFSBucketOptions = new GridFSBucketOptions()
				{
					BucketName = "images",
					ChunkSizeBytes = 1048576, // 1МБ
				};

				_bucket = new GridFSBucket(_database, gridFSBucketOptions);

			}
		}


		public IMongoCollection<CompleteTestResult> TestResults
		{
			get
			{
				return _database.GetCollection<CompleteTestResult>(DbName);
			}
		}


		public GridFSBucket Bucket
		{
			get
			{
				return _bucket;
			}
		}


		private String DbName => "TesterDb";
	}
}
