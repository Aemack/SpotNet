namespace SpotNet.Models
{
    public class Album
    {

        public string Id { get; set; }
        public string Name { get; set; }
        public string MyProperty { get; set; }
        public string ImageUrl { get; set; }
        public string  ReleaseDate { get; set; }
        public List<Track> Tracks { get; set; }
        public List<Artist> Artists { get; set; }
        public List<string> Genres { get; set; }
    }
}
