using Models.ServiceModels;
using Models.VideoGameModel;
using System.Collections.Generic;
using System;

namespace Presenters.Edit
{
    public class EditPresenter : IEditPresenter
    {
        private readonly IEditView _view;
        
        public bool EditMode { get; }

        public EditPresenter(IEditView view, bool editMode)
        {
            _view = view;
            EditMode = editMode;
            _view.FormName = editMode ? "Edit" : "Add";
        }

        public bool CollectInfo()
        {
            try
            {
                VideoGameService.Title = _view.Title;
                VideoGameService.Developer = _view.Developer;
                VideoGameService.Publisher = _view.Publisher;
                VideoGameService.Website = _view.Website;
                VideoGameService.ReleaseDate = _view.ReleaseDate;

                var platforms = new List<TypePlatform>();
                if (_view.PC) platforms.Add(TypePlatform.PC);
                if (_view.PlayStation) platforms.Add(TypePlatform.PlayStation);
                if (_view.Xbox) platforms.Add(TypePlatform.Xbox);
                if (_view.Android) platforms.Add(TypePlatform.Android);
                if (_view.iOS) platforms.Add(TypePlatform.iOS);

                var genres = new List<TypeGenre>();
                if (_view.Action) genres.Add(TypeGenre.Action);
                if (_view.Adventure) genres.Add(TypeGenre.Adventure);
                if (_view.RPG) genres.Add(TypeGenre.RPG);
                if (_view.Strategy) genres.Add(TypeGenre.Strategy);
                if (_view.Racing) genres.Add(TypeGenre.Racing);

                VideoGameService.Platforms = platforms;
                VideoGameService.Genres = genres;
                VideoGameService.About = _view.About;
            }
            catch (ArgumentException) { return false; }

            return true;
        }

        public void LoadInfo()
        {
            _view.Title = VideoGameService.Title;
            _view.Developer = VideoGameService.Developer;
            _view.Publisher = VideoGameService.Publisher;
            _view.Website = VideoGameService.Website;
            _view.ReleaseDate = VideoGameService.ReleaseDate;

            foreach (var platform in VideoGameService.Platforms)
            {
                switch (platform)
                {
                   case TypePlatform.PC: _view.PC = true; break;
                   case TypePlatform.PlayStation: _view.PlayStation = true; break;
                   case TypePlatform.Xbox: _view.Xbox = true; break;
                   case TypePlatform.Android: _view.Android = true; break;
                   case TypePlatform.iOS: _view.iOS = true; break;
                   default: return;
                }
            }

            foreach (var genre in VideoGameService.Genres)
            {
                switch (genre)
                {
                   case TypeGenre.Action: _view.Action = true; break;
                   case TypeGenre.Adventure: _view.Adventure = true; break;
                   case TypeGenre.RPG: _view.RPG = true; break;
                   case TypeGenre.Strategy: _view.Strategy = true; break;
                   case TypeGenre.Racing: _view.Racing = true; break;
                   default: return;
                }
            }
            
            _view.About = VideoGameService.About;
        }
    }
}
