using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using VLUTESTAPI.Models;

namespace VLUTESTAPI.Services
{
    public class TestService
    {
        private readonly IMongoCollection<TestModels> _examples;

        public TestService(IMongoDatabase database)
        {
            _examples = database.GetCollection<TestModels>("TESTCOLLECTION");
        }

        public async Task<List<TestModels>> GetAllExamplesAsync()
        {
            return await _examples.Find(_ => true).ToListAsync();
        }
    }
}
