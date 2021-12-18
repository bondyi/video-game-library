using System.ComponentModel;
using Models.VideoGameModel;
using Models.ServiceModels;
using System.Linq;

namespace Presenters.Main
{
    public class MainPresenter : IMainPresenter
    {
        private readonly IMainView _view;
        private readonly VideoGameDatabaseService _databaseService;

        public MainPresenter(IMainView view)
        {
            _view = view;
            _databaseService = new VideoGameDatabaseService();
            
            UpdateView();
        }

        public void UpdateView()
        {
            _view.VideoGameList = _databaseService.GetDataSource();
            if (_view.VideoGameList.Count != 0) Sort();
        }

        public void EditVideoGame()
        {
            _databaseService.Update(VideoGameService.Game);
            UpdateView();
        }
        
        public void AddVideoGame()
        {
            _databaseService.Add(VideoGameService.Game);
            UpdateView();
        }

        public void DeleteVideoGame(VideoGame videoGame)
        {
            _databaseService.Remove(videoGame);
            UpdateView();
        }

        public void Find()
        {
            var result = new BindingList<VideoGame>();

            if (_view.FiltrationTitle)
            {
                foreach (var videoGame in _databaseService.GetDataSource())
                {
                    if (videoGame.Title.ToLower()
                        .StartsWith(_view.FiltrationString.ToLower()))
                        result.Add(videoGame);
                }
            }
            else if (_view.FiltrationDeveloper)
            {
                foreach (var videoGame in _databaseService.GetDataSource())
                {
                    if (videoGame.Developer.ToLower()
                        .StartsWith(_view.FiltrationString.ToLower()))
                        result.Add(videoGame);
                }
            }
            else if (_view.FiltrationPublisher)
            {
                foreach (var videoGame in _databaseService.GetDataSource())
                {
                    if (videoGame.Publisher.ToLower()
                        .StartsWith(_view.FiltrationString.ToLower()))
                        result.Add(videoGame);
                }
            }

            if (_view.ReleaseDate)
            {
                var resultReleaseDate = new BindingList<VideoGame>();
                
                foreach (var videoGame in result)
                {
                    if (videoGame.ReleaseDate >= _view.DateTimeFrom &&
                        videoGame.ReleaseDate <= _view.DateTimeTo)
                        resultReleaseDate.Add(videoGame);
                }

                result = resultReleaseDate;
            }
            
            if (_view.PC || _view.PlayStation || _view.Xbox || _view.Android || _view.iOS)
            {
                var resultPlatforms = new BindingList<VideoGame>();
                
                foreach (var videoGame in result)
                {
                    foreach (var platform in videoGame.Platforms)
                    {
                        if ((_view.PC && platform == TypePlatform.PC) |
                            (_view.PlayStation && platform == TypePlatform.PlayStation) |
                            (_view.Xbox && platform == TypePlatform.Xbox) |
                            (_view.Android && platform == TypePlatform.Android) |
                            (_view.iOS && platform == TypePlatform.iOS)) 
                            resultPlatforms.Add(videoGame);
                    }
                }
                
                result = resultPlatforms;
            }

            if (_view.Action || _view.Adventure || _view.RPG || _view.Strategy || _view.Racing)
            {
                var resultGenres = new BindingList<VideoGame>();

                foreach (var videoGame in result)
                {
                    foreach (var genre in videoGame.Genres)
                    {
                        if ((_view.Action && genre == TypeGenre.Action) |
                            (_view.Adventure && genre == TypeGenre.Adventure) |
                            (_view.RPG && genre == TypeGenre.RPG) |
                            (_view.Strategy && genre == TypeGenre.Strategy) |
                            (_view.Racing && genre == TypeGenre.Racing))
                            resultGenres.Add(videoGame);
                    }
                }

                result = resultGenres;
            }


            if (result.Count != 0)
            {
                _view.VideoGameList = new BindingList<VideoGame>(result.Distinct().ToList());
                Sort();
            }
            else _view.Message("Nothing found...", "Message");
        }

        public void Sort()
        {
            BindingList<VideoGame> sortedList;
            if (_view.SortByTitle)
            {
                sortedList = _view.SortByAscending ?
                    new BindingList<VideoGame>(_view.VideoGameList.OrderBy(videoGame => videoGame.Title).ToList()) : 
                    new BindingList<VideoGame>(_view.VideoGameList.OrderByDescending(videoGame => videoGame.Title).ToList());
            }
            else
            {
                sortedList = _view.SortByAscending ?
                    new BindingList<VideoGame>(_view.VideoGameList.OrderBy(videoGame => videoGame.ReleaseDate).ToList()) :
                    new BindingList<VideoGame>(_view.VideoGameList.OrderByDescending(videoGame => videoGame.ReleaseDate).ToList());
            }

            _view.VideoGameList = sortedList;
        }

        public void Serialize() => _databaseService.Serialize();
    }
}
