using AnimeDesktop.ViewModel;

namespace AnimeDesktop.Model.Commands.BookmarkModelUpdater
{
    public class AbandonedSetterCommand : BaseBookmarkUpdaterCommand
    {
        public AbandonedSetterCommand(IBookmarksModel bookmarksModel) : base(bookmarksModel)
        {
        }

        public override void Execute(object? parameter)
        {
            _bookmarksModel.UpdateToAbondoned();
        }
    }
}
