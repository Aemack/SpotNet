namespace SpotNet.Models
{
    public class Track
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Album Album { get; set; }
        public List<Artist> Artists { get; set; }
        public List<string> Genres { get; set; }
        public string Tempo { get; set; }
        public string Bars { get; set; }
        public string Beats { get; set; }
    }
}
