using System;
using System.Collections.Generic;

namespace Models.VideoGameModel
{
    [Serializable]
    public class VideoGame
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string About { get; set; }
        public List<TypePlatform> Platforms { get; set; }
        public List<TypeGenre> Genres { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Developer { get; set; }
        public string Publisher { get; set; }
        public string Website { get; set; }

        public VideoGame() => Id = Guid.NewGuid().ToString();
    }
}
