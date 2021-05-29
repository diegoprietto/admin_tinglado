using MongoDB.Driver;

namespace Admin_Tinglado.Repository
{
    public class TingladoRepository : ITingladoRepository
    {
        static MongoClient _mongoClient;

        public TingladoRepository(MongoClient mongoClient)
        {
            _mongoClient = mongoClient;
        }


    }
}
