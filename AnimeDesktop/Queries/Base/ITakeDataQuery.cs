namespace AnimeDesktop.Model
{
    public interface ITakeDataQuery<T>
    {
        public Task<T> TakeDataAsync();
    }
}
