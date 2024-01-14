namespace AnimeDesktop.ViewModel
{
    public interface IBookmarksModel
    {
        void UpdateToAbondoned();
        void UpdateToPlanned();
        void UpdateToWatched();
    }
}