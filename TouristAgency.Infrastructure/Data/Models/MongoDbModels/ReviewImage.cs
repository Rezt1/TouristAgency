using MongoDB.Bson.Serialization.Attributes;

namespace TouristAgency.Infrastructure.Data.Models.MongoDbModels
{
    public class ReviewImage
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string? Id { get; set; }

        public byte[] Data { get; set; } = null!;

        public int ReviewId { get; set; }
    }
}
