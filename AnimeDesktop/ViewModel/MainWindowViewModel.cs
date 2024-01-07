using AnimeDesktop.Base;
using AnimeDesktop.Init;
using AnimeDesktop.Navigation;
using AnimeDesktop.View;
using Microsoft.Extensions.DependencyInjection;
using ShikimoriSharp.Classes;
using System.Windows.Controls;

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
