using System;
using System.ComponentModel;
using Models.VideoGameModel;

namespace Models.VideoGameDatabaseModel
{
    [Serializable]
    public class VideoGameDatabase
    {
        public BindingList<VideoGame> VideoGames { get; set; }

        public VideoGameDatabase() => VideoGames = new BindingList<VideoGame>();

        public void Add(VideoGame videoGame) => VideoGames.Add(videoGame);
        public void Remove(VideoGame videoGame) => VideoGames.Remove(videoGame);
        public void Update(VideoGame videoGame)
        {
            var count = VideoGames.Count;
            if (count <= 0) return;
            
            for (var i = 0; i < count; ++i)
            {
                if (VideoGames[i].Id == videoGame.Id)
                {
                    VideoGames[i] = videoGame;
                }
            }
        }
    }
}
