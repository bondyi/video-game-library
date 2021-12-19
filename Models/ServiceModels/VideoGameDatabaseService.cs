using Models.DatabaseContextModel;
using Models.VideoGameRepositoryModel;
using Models.VideoGameModel;
using System.ComponentModel;
using System.IO;

namespace Models.ServiceModels
{
    public class VideoGameDatabaseService
    {
        private readonly VideoGameDatabaseContext _context;
        private readonly VideoGameRepository _repository;

        public VideoGameDatabaseService()
        {
            _context = new VideoGameDatabaseContext();
            _repository = File.Exists(VideoGameDatabaseContext.Path) ? _context.Deserialize() : new VideoGameRepository();
        }

        public BindingList<VideoGame> GetDataSource() => _repository.VideoGames;

        public void Add(VideoGame videoGame) => _repository.Add(videoGame);
        public void Remove(VideoGame videoGame) => _repository.Remove(videoGame);
        public void Update(VideoGame videoGame) => _repository.Update(videoGame);

        public void Serialize() => _context.Serialize(_repository);
    }
}
