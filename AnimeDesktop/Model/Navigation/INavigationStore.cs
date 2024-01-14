using AnimeDesktop.ViewModel;

namespace AnimeDesktop.Model.Navigation
{
    public interface INavigationStore
    {
        public event Action CurrentViewModelChanged;
        public BaseAnimeListViewModel CurrentViewModel { get; }

        public void SetViewModel(BaseAnimeListViewModel viewModel);
    }
}
