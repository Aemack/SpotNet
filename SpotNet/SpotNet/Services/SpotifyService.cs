using Microsoft.AspNetCore.Components;
using SpotifyAPI.Web;
using SpotNet.Models;
using SpotNet.Pages;

namespace SpotNet.Services
{
    public class SpotifyService
    {
        SpotifyClient spotify;
        NavigationManager navManager;
        string access_token;
        bool _isAuthed;
        

        public async Task GetSpotifyAuthorized()
        {
            var uri = new Uri(navManager.Uri);
            var maxLen = Math.Min(1, uri.Fragment.Length);
            Dictionary<string, string> fragmentParams = uri.Fragment.Substring(maxLen)?
              .Split("&", StringSplitOptions.RemoveEmptyEntries)?
              .Select(param => param.Split("=", StringSplitOptions.RemoveEmptyEntries))?
              .ToDictionary(param => param[0], param => param[1]) ?? new Dictionary<string, string>();

            _isAuthed = fragmentParams.ContainsKey("access_token");
            if (_isAuthed)
            {
                var playlistId = fragmentParams["id"];
                spotify = new SpotifyClient(fragmentParams["access_token"]);
                access_token = fragmentParams["access_token"];
                await GetUserPlaylist(playlistId);
            }
        }
        

        private async Task<Playlist> GetUserPlaylist(string playlistId)
        {
            var playlist = new Playlist();
            var playlistJson = await spotify.Playlists.Get(playlistId);
            playlist.Tracks = new List<Track>();
            playlist.Name = playlistJson.Name;
            var gotEmAll = false;
            while (!gotEmAll)
            {
                foreach (var track in playlistJson.Tracks.Items)
                {
                    var parsedTrack = (FullTrack)track.Track;
                    var newTrack = new Track();
                    newTrack.Name = parsedTrack.Name;
                    if (parsedTrack.Album != null) newTrack.Album = new Album() { Name = parsedTrack.Album.Name, Id = parsedTrack.Id };
                    if (parsedTrack.Artists.Count > 0)
                    {
                        newTrack.Artists = new List<Artist>();
                        foreach (var art in parsedTrack.Artists)
                        {
                            newTrack.Artists.Add(new Artist() { Name = art.Name, Id = art.Id });
                        }

                    }
                    playlist.Tracks.Add(newTrack);
                }

                if (!string.IsNullOrWhiteSpace(playlistJson.Tracks.Next))
                {
                    playlistJson.Tracks = await spotify.NextPage(playlistJson.Tracks);
                }
                else
                {
                    gotEmAll = true;
                }
            }

            return playlist;
        }
    }
}
