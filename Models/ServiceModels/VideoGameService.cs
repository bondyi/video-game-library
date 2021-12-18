using Models.VideoGameModel;
using System;
using System.Collections.Generic;

namespace Models.ServiceModels
{
    public static class VideoGameService
    {
        public static VideoGame Game { get; set; }
        public static string Title
        {
            get => Game.Title;
            set => Game.Title = string.IsNullOrEmpty(value) ? throw new ArgumentException() : value;
        }
        public static string About
        {
            get => Game.About;
            set => Game.About = string.IsNullOrEmpty(value) ? throw new ArgumentException() : value;
        }
        public static List<TypePlatform> Platforms
        {
            get => Game.Platforms;
            set => Game.Platforms = value.Count == 0 ? throw new ArgumentException() : value;
        }
        public static List<TypeGenre> Genres
        {
            get => Game.Genres;
            set => Game.Genres = value.Count == 0 ? throw new ArgumentException() : value;
        }
        public static DateTime ReleaseDate
        {
            get => Game.ReleaseDate;
            set => Game.ReleaseDate = value;
        }
        public static string Developer
        {
            get => Game.Developer;
            set => Game.Developer = string.IsNullOrEmpty(value) ? throw new ArgumentException() : value;
        }
        public static string Publisher
        {
            get => Game.Publisher;
            set => Game.Publisher = string.IsNullOrEmpty(value) ? throw new ArgumentException() : value;
        }
        public static string Website
        {
            get => Game.Website;
            set => Game.Website = value.StartsWith("https://") || value.Contains("www.") ? value : throw new ArgumentException();
        }
    }
}
