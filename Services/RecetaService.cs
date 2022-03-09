using Interfaces;
using Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class RecetaService : IReceta
    {
        private readonly IMongoCollection<Receta> collection;
        public RecetaService(IMongodb context)
        {
            var client = new MongoClient(context.Server);
            var db = client.GetDatabase(context.Database);
            collection = db.GetCollection<Receta>("Recetas");
        }

        public async Task deleteOne(string id)
        {
            var filter = Builders<Receta>.Filter.Eq(x => x.id, id);
            await collection.DeleteOneAsync(filter);
        }

        public async Task<IList<Receta>> getAll()
        {
            return await collection.FindAsync(new BsonDocument { }).Result.ToListAsync();
        }

        public async Task<Receta> getById(string id)
        {
            return await collection.FindAsync(new BsonDocument { { "_id", id} }).Result.FirstAsync();
        }

        public async Task saveOne(Receta receta)
        {
            await collection.InsertOneAsync(receta);
        }

        public async Task updateOne(Receta receta)
        {
            var filter = Builders<Receta>.Filter.Eq(x =>x.id, receta.id);
            await collection.ReplaceOneAsync(filter, receta);
        }
    }
}
