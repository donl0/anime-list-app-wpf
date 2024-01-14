using System.Windows.Input;

namespace AnimeDesktop.Model.Commands.BookmarkModelUpdater
{
    public class BookmarksCommandsContainer
    {
        public ICommand WatchedSetter { get; private set; }
        public ICommand PlannedSetter { get; private set; }
        public ICommand AbondonedSetter { get; private set; }

        public BookmarksCommandsContainer(ICommand watchedSetter, ICommand plannedSetter, ICommand abondonedSetter)
        {
            WatchedSetter = watchedSetter;
            PlannedSetter = plannedSetter;
            AbondonedSetter = abondonedSetter;
        }
    }
}
