using Models.VideoGameModel;

namespace Presenters.Main
{
    public interface IMainPresenter
    {
        void UpdateView();
        void EditVideoGame();
        void AddVideoGame();
        void DeleteVideoGame(VideoGame videoGame);
        void Find();
        void Sort();
        void Serialize();
    }
}