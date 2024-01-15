using AnimeDesktop.Model;
using ShikimoriSharp.Classes;
using AnimeDesktop.Servises.DSRuler;
using AnimeDesktop.Model.Commands;
using AnimeDesktop.Model.Bookmarks;
using System.Windows.Input;
using AnimeDesktop.DB.Model;

namespace AnimeDesktop.ViewModel
{
    public class UserBookmarksViewModel : BaseAnimeListViewModel, IBookmarksModel
    {
        private ITakeDataQuery<List<Anime>> _watchedQuery;
        private ITakeDataQuery<List<Anime>> _plannedQuery;
        private ITakeDataQuery<List<Anime>> _abandonedQuery;
   
        public ICommand WatchedSetter { get; private set; }
        public ICommand PlannedSetter { get; private set; }
        public ICommand AbondonedSetter { get; private set; }

        public UserBookmarksViewModel(TakeAllFromUserBookmark<PlannedAnime> plannedQuery, TakeAllFromUserBookmark<WatchedAnime> watchedQuery, TakeAllFromUserBookmark<AbandonedAnime> abandonedQuerry, OpenAnimeWindowCommand openAnime, IShikiRuler<List<Anime>> imageRuler) : base(watchedQuery, openAnime, imageRuler)
        {
            _watchedQuery = watchedQuery;
            _plannedQuery = plannedQuery;
            _abandonedQuery = abandonedQuerry;
        }

        public void UpdateToWatched()
        {
            UpdateWithQuerry(_watchedQuery);
        }

        public void UpdateToPlanned()
        {
            UpdateWithQuerry(_plannedQuery);
        }

        public void UpdateToAbondoned()
        {
            UpdateWithQuerry(_abandonedQuery);
        }
    }
}
