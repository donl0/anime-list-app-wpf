using AnimeDesktop.Commands;
using AnimeDesktop.Navigation.Commands;

namespace AnimeDesktop.ViewModel
{
    public class HeaderNavigationViewModel
    {
        public NavigateCommand<TopHundredViewModel> NavigateTopAnimes { get; }
        public NavigateCommand<UserBookmarksViewModel> NavigateBookmarks { get; }
        public SearchAnimeCommand<SearchAnimesViewModel> NavigateSearch { get; }

        public HeaderNavigationViewModel(NavigateCommand<TopHundredViewModel> navigateTopAnimes, NavigateCommand<UserBookmarksViewModel> navigateBookmarks, SearchAnimeCommand<SearchAnimesViewModel> navigationSearch)
        {
            NavigateTopAnimes = navigateTopAnimes;
            NavigateBookmarks = navigateBookmarks;
            NavigateSearch = navigationSearch;
        }
    }
}
