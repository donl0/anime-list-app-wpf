using AnimeDesktop.ViewModel;

namespace AnimeDesktop.Model.Commands.BookmarkModelUpdater
{
    public abstract class BaseBookmarkUpdaterCommand : BaseCommand
    {
        protected readonly IBookmarksModel _bookmarksModel;

        public BaseBookmarkUpdaterCommand(IBookmarksModel bookmarksModel)
        {
            _bookmarksModel = bookmarksModel;
        }
    }
}
