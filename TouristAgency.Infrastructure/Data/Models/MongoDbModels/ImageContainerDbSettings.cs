namespace TouristAgency.Infrastructure.Data.Models.MongoDbModels
{
    public class ImageContainerDbSettings
    {
        public string ConnectionString { get; set; } = string.Empty;

        public string DatabaseName { get; set; } = string.Empty;

        public string ImagesCollectionName { get; set; } = string.Empty;
    }
}
