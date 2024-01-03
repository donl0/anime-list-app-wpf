using AnimeDesktop.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeDesktop.Navigation
{
    class NavigationStore : INavigationStore
    {
        public BaseAnimeListViewModel CurrentViewModel { get; private set; }

        public event Action CurrentViewModelChanged;

        public NavigationStore(BaseAnimeListViewModel startView)
        {
            SetViewModel(startView);
        }

        public void SetViewModel(BaseAnimeListViewModel viewModel)
        {
            CurrentViewModel = viewModel;
            CurrentViewModelChanged?.Invoke();
        }
    }
}
