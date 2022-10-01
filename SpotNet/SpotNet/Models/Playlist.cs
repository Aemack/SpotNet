namespace SpotNet.Models
{
    public class Playlist
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }

        public List<Track> Tracks { get; set; }


        public string GetPlaylistUrl(string _accessToken)
        {
            return $"playlist#access_token={_accessToken}&&id={Id}";
        }
    }
}
