namespace SpotNet.Models
{
    public class RecomendationOptions
    {
        public Dictionary<string, float> Options;
        public Dictionary<string, bool> optionsActive { get; set; }
        public Dictionary<string, float> optionsMaxs { get; set; }
        public Dictionary<string, float> optionsMins { get; set; }

        public RecomendationOptions()
        {
            optionsActive = new Dictionary<string,bool>();
            optionsActive.Add("tempo", false);
            optionsActive.Add("acousticness", false);
            optionsActive.Add("danceability", false);
            optionsActive.Add("energy", false);
            optionsActive.Add("instrumentalness", false);
            optionsActive.Add("liveness", false);
            optionsActive.Add("loudness", false);
            optionsActive.Add("mode", false);
            optionsActive.Add("popularity", false);
            optionsActive.Add("speechiness", false);
            optionsActive.Add("time_signature", false);
            optionsActive.Add("key", false);
            optionsActive.Add("valence", false);

            Options = new Dictionary<string, float>();
            Options.Add("tempo", 0f);
            Options.Add("acousticness", 0f);
            Options.Add("danceability", 0f);
            Options.Add("energy", 0f);
            Options.Add("instrumentalness", 0f);
            Options.Add("liveness", 0f);
            Options.Add("loudness", 0f);
            Options.Add("mode", 0f);
            Options.Add("popularity", 0f);
            Options.Add("speechiness", 0f);
            Options.Add("time_signature", 0f);
            Options.Add("valence", 0f);
            Options.Add("key", 0f);

            optionsMins = new Dictionary<string, float>();


            optionsMaxs = new Dictionary<string, float>();
            optionsMaxs.Add("tempo", 250f);
            optionsMaxs.Add("acousticness", 1f);
            optionsMaxs.Add("danceability", 1f);
            optionsMaxs.Add("energy", 1f);
            optionsMaxs.Add("instrumentalness", 1f);
            optionsMaxs.Add("liveness", 1f);
            optionsMaxs.Add("loudness", 1f);
            optionsMaxs.Add("mode", 1f);
            optionsMaxs.Add("popularity", 100f);
            optionsMaxs.Add("speechiness", 1f);
            optionsMaxs.Add("time_signature", 1f);
            optionsMaxs.Add("valence", 1f);
            optionsMaxs.Add("key", 11f);
        }

        public void ResetOptions()
        {
            Options = new Dictionary<string, float>();
            Options.Add("tempo", 0f);
            Options.Add("acousticness", 0f);
            Options.Add("danceability", 0f);
            Options.Add("energy", 0f);
            Options.Add("instrumentalness", 0f);
            Options.Add("liveness", 0f);
            Options.Add("loudness", 0f);
            Options.Add("mode", 0f);
            Options.Add("popularity", 0f);
            Options.Add("speechiness", 0f);
            Options.Add("time_signature", 0f);
            Options.Add("valence", 0f);
            Options.Add("key", 0f);
        }


        //public RecomendationOptions()
        //{
        //    optionsActive = new Dictionary<string,bool>();
        //    optionsActive.Add("target_tempo", false);
        //    optionsActive.Add("target_acousticness", false);
        //    optionsActive.Add("target_danceability", false);
        //    optionsActive.Add("target_energy", false);
        //    optionsActive.Add("target_instrumentalness", false);
        //    optionsActive.Add("target_liveness", false);
        //    optionsActive.Add("target_loudness", false);
        //    optionsActive.Add("target_mode", false);
        //    optionsActive.Add("target_popularity", false);
        //    optionsActive.Add("target_speechiness", false);
        //    optionsActive.Add("target_time_signature", false);
        //    optionsActive.Add("target_key", false);
        //    optionsActive.Add("target_valence", false);

        //    Options = new Dictionary<string, float>();
        //    Options.Add("target_tempo", 0f);
        //    Options.Add("target_acousticness", 0f);
        //    Options.Add("target_danceability", 0f);
        //    Options.Add("target_energy", 0f);
        //    Options.Add("target_instrumentalness", 0f);
        //    Options.Add("target_liveness", 0f);
        //    Options.Add("target_loudness", 0f);
        //    Options.Add("target_mode", 0f);
        //    Options.Add("target_popularity", 0f);
        //    Options.Add("target_speechiness", 0f);
        //    Options.Add("target_time_signature", 0f);
        //    Options.Add("target_valence", 0f);
        //    Options.Add("target_key", 0f);

        //    optionsMins = new Dictionary<string, float>();


        //    optionsMaxs = new Dictionary<string, float>();
        //    optionsMaxs.Add("target_tempo", 300f);
        //    optionsMaxs.Add("target_acousticness", 1f);
        //    optionsMaxs.Add("target_danceability", 1f);
        //    optionsMaxs.Add("target_energy", 1f);
        //    optionsMaxs.Add("target_instrumentalness", 1f);
        //    optionsMaxs.Add("target_liveness", 1f);
        //    optionsMaxs.Add("target_loudness", 1f);
        //    optionsMaxs.Add("target_mode", 1f);
        //    optionsMaxs.Add("target_popularity", 100f);
        //    optionsMaxs.Add("target_speechiness", 1f);
        //    optionsMaxs.Add("target_time_signature", 1f);
        //    optionsMaxs.Add("target_valence", 1f);
        //    optionsMaxs.Add("target_key", 11f);
        //}

        //public void ResetOptions()
        //{
        //    Options = new Dictionary<string, float>();
        //    Options.Add("target_tempo", 0f);
        //    Options.Add("target_acousticness", 0f);
        //    Options.Add("target_danceability", 0f);
        //    Options.Add("target_energy", 0f);
        //    Options.Add("target_instrumentalness", 0f);
        //    Options.Add("target_liveness", 0f);
        //    Options.Add("target_loudness", 0f);
        //    Options.Add("target_mode", 0f);
        //    Options.Add("target_popularity", 0f);
        //    Options.Add("target_speechiness", 0f);
        //    Options.Add("target_time_signature", 0f);
        //    Options.Add("target_valence", 0f);
        //    Options.Add("target_key", 0f);
        //}
    }
}
