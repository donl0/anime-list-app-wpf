using AnimeDesktop.Base;
using AnimeDesktop.Navigation;

namespace AnimeDesktop.ViewModel
{
    public class MainWindowViewModel : NotifyPropertyChangeViewModel
    {
        private readonly INavigationStore _navigationStore;

        public BaseAnimeListViewModel CurrentViewModel => _navigationStore.CurrentViewModel;

        public MainWindowViewModel(INavigationStore navigation) {
            _navigationStore = navigation;

            _navigationStore.CurrentViewModelChanged += OnNavigationChanged;
        }

        private void OnNavigationChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }
    }
}
