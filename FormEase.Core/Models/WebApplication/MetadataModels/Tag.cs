namespace FormEase.Core.Models.WebApplication.MetadataModels
{
    public class Tag
    {
        public Guid Id { get; set; }
        public string Name { get; set; } // Unique tag name
        public DateTime FirstUsed { get; set; } = DateTime.UtcNow;
    }
}
