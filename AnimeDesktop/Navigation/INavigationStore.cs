using AnimeDesktop.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeDesktop.Navigation
{
    public interface INavigationStore
    {
        public BaseAnimeListViewModel CurrentViewModel { get; }
        public event Action CurrentViewModelChanged;

        public void SetViewModel(BaseAnimeListViewModel viewModel);
    }
}
