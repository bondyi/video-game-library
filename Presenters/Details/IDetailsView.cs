namespace Presenters.Details
{
    public interface IDetailsView
    {
        string Title { get; set; }
        string About { get; set; }
        string Platforms { get; set; }
        string Genres { get; set; }
        string ReleaseDate { get; set; }
        string Developer { get; set; }
        string Publisher { get; set; }
    }
}