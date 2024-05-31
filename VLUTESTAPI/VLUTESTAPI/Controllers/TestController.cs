using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using VLUTESTAPI.Models;

namespace VLUTESTAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
               
        private readonly IMongoDatabase _database;

        public TestController(IMongoClient mongoClient)
        {
            _database = mongoClient.GetDatabase("VLUTESTDB");
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<BsonDocument>>> GetAllDocuments()
        {
            var collection = _database.GetCollection<BsonDocument>("TESTCOLLECTION");
            var documents = await collection.Find(_ => true).ToListAsync();
            Console.WriteLine(documents);
            return documents;
        }



        // GET: api/GetAllCollection
        /* [HttpGet]
         public async Task<ActionResult<IEnumerable<YourCollectionType>>> GetAllCollection()
         {
             var database = _mongoClient.GetDatabase("YourDatabaseName");
             var collection = database.GetCollection<YourCollectionType>("YourCollectionName");
             var documents = await collection.Find(_ => true).ToListAsync();

             return documents;
         }*/

    }
}
