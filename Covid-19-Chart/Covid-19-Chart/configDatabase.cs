using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using System.Configuration;
using MongoDB.Bson;
using System.Security;
using System.Net;


namespace Covid_19_Chart
{

    public class ConfigDataBase
    {
        private MongoClient dbClient = new MongoClient("mongodb://mongodb0.example.com:27017");
        public IMongoDatabase GetDatabase() { return dbClient.GetDatabase("TheGardenGroup_Database"); }


    }
}
