using MongoDB.Bson.Serialization.Attributes;

namespace TouristAgency.Infrastructure.Data.Models.MongoDbModels
{
    public class Image
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string? Id { get; set; }

        public byte[] Data { get; set; } = null!;
    }
}
