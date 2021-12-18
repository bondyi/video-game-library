using System;

namespace Presenters.Edit
{
    public interface IEditView
    {
        string FormName { set; }
        
        string Title { get; set; }
        string Developer { get; set; }
        string Publisher { get; set; }
        string Website { get; set; }

        DateTime ReleaseDate { get; set; }

        bool PC { get; set; }
        bool PlayStation { get; set; }
        bool Xbox { get; set; }
        bool Android { get; set; }
        bool iOS { get; set; }

        bool Action { get; set; }
        bool Adventure { get; set; }
        bool RPG { get; set; }
        bool Strategy { get; set; }
        bool Racing { get; set; }
        
        string About { get; set; }
    }
}
