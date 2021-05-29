using MongoDB.Driver;
using System;

namespace Admin_Tinglado.Configuration
{
    public static class Configuration
    {
        static MongoClient _mongoClient;

        static Configuration()
        {
            string connectionString = Environment.GetEnvironmentVariable("AdminTingladoMongo");
            _mongoClient = new MongoClient(connectionString);
        }

        public static MongoClient GetMongoClient()
        {
            return _mongoClient;
        }
    }
}
