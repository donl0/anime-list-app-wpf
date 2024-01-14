using AnimeDesktop.ViewModel;

namespace AnimeDesktop.Model.Commands.BookmarkModelUpdater
{
    public class PlannedSetterCommand : BaseBookmarkUpdaterCommand
    {
        public PlannedSetterCommand(IBookmarksModel bookmarksModel) : base(bookmarksModel)
        {
        }

        public override void Execute(object? parameter)
        {
            _bookmarksModel.UpdateToPlanned();
        }
    }
}
