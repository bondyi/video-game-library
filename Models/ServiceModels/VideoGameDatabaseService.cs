using Models.RepositoryModel;
using Models.VideoGameDatabaseModel;
using Models.VideoGameModel;
using System.ComponentModel;
using System.IO;

namespace Models.ServiceModels
{
    public class VideoGameDatabaseService
    {
        private readonly VideoGameDatabaseRepository _repository;
        private readonly VideoGameDatabase _database;

        public VideoGameDatabaseService()
        {
            _repository = new VideoGameDatabaseRepository();
            _database = File.Exists(VideoGameDatabaseRepository.Path) ? _repository.Deserialize() : new VideoGameDatabase();
        }

        public BindingList<VideoGame> GetDataSource() => _database.VideoGames;

        public void Add(VideoGame videoGame) => _database.Add(videoGame);
        public void Remove(VideoGame videoGame) => _database.Remove(videoGame);
        public void Update(VideoGame videoGame) => _database.Update(videoGame);

        public void Serialize() => _repository.Serialize(_database);
    }
}
