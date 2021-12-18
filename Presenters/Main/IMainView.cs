using System;
using System.ComponentModel;
using Models.VideoGameModel;

namespace Presenters.Main
{
    public interface IMainView
    {
        string FiltrationString { get; }
        
        bool FiltrationTitle { get; }
        bool FiltrationDeveloper { get; }
        bool FiltrationPublisher { get; }
        
        bool ReleaseDate { get; }
        DateTime DateTimeFrom { get; }
        DateTime DateTimeTo { get; }

        bool PC { get; }
        bool PlayStation { get; }
        bool Xbox { get; }
        bool Android { get; }
        bool iOS { get; }

        bool Action { get; }
        bool Adventure { get; }
        bool RPG { get; }
        bool Strategy { get; }
        bool Racing { get; }

        bool SortByTitle { get; }

        bool SortByAscending { get; }

        BindingList<VideoGame> VideoGameList { get; set; }

        void Message(string text, string caption);
    }
}
