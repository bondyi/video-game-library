namespace Presenters.Edit
{
    public interface IEditPresenter
    {
        bool EditMode { get; }
        bool CollectInfo();
        void LoadInfo();
    }
}