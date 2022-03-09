using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Receta
    {
        public Receta()
        {
            codigo = Guid.NewGuid().ToString();
        }
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }
        [BsonElement]
        public string nombre { get; set; }
        public string codigo { get; set; }
        public List<Ingrediente> ingredientes { get; set; }
    }
}
