namespace SpotNet.Models
{
    public class Artist
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public List<string> Genres { get; set; }
    }
}
