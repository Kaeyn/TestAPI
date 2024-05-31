using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VLUTESTAPI.Models
{
    public class MongoSetting : IMongoSettings
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IMongoSettings
    {
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
