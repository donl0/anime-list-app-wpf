using AnimeDesktop.ViewModel;

namespace AnimeDesktop.Model.Commands.BookmarkModelUpdater
{
    public class WatchedSetterCommand : BaseBookmarkUpdaterCommand
    {
        public WatchedSetterCommand(IBookmarksModel bookmarksModel) : base(bookmarksModel)
        {
        }

        public override void Execute(object? parameter)
        {
            _bookmarksModel.UpdateToWatched();
        }
    }
}
