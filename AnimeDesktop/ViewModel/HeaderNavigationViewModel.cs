using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AnimeDesktop.ViewModel
{
    class HeaderNavigationViewModel
    {
        public ICommand NavigateTopAnimes { get; }
        public ICommand NavigateSearch { get; }
        public ICommand NavigateBookmarks { get; }
    }
}
