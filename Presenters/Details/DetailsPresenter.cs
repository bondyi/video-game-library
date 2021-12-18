using System.Text;
using Models.ServiceModels;

namespace Presenters.Details
{
    public class DetailsPresenter : IDetailsPresenter
    {
        private readonly IDetailsView _view;

        public DetailsPresenter(IDetailsView view)
        {
            _view = view;
        }

        public void LoadInfo()
        {
            _view.Title = VideoGameService.Title;
            _view.About = VideoGameService.About;

            var stringBuilder = new StringBuilder();
            foreach (var platform in VideoGameService.Platforms) stringBuilder.Append(platform.ToString() + ' ');
            _view.Platforms = stringBuilder.ToString();

            stringBuilder.Clear();
            foreach (var genre in VideoGameService.Genres) stringBuilder.Append(genre.ToString() + ' ');
            _view.Genres = stringBuilder.ToString();

            _view.ReleaseDate = VideoGameService.ReleaseDate.ToShortDateString();
            _view.Developer = VideoGameService.Developer;
            _view.Publisher = VideoGameService.Publisher;
        }
    }
}
