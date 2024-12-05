using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace vRootProject.Custom.Mongo.ProductMongo.ProductModelMongo
{
    public class ProductMong
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = null!;

        [BsonElement("Name")]
        public string Name { get; set; } = null!;

        [BsonElement("Description")]
        public string Description { get; set; } = null!;

        [BsonElement("Price")]
        public decimal Price { get; set; }

        [BsonElement("Category")]
        public string Category { get; set; } = null!;

        [BsonElement("InStock")]
        public bool InStock { get; set; }
    }
}
