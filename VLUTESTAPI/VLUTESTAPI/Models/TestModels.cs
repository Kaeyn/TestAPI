using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace VLUTESTAPI.Models
{
    public class TestModels
    {     
        public ObjectId _id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }

        public TestModels(string name, string desc, DateTime createdDate)
        {
            this.Name = name;
            this.Description = desc;
            this.CreatedAt = createdDate;
        }
    }
}
