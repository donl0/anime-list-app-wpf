namespace AnimeDesktop.Model
{
    internal interface ITakeDataQuery<T>
    {
        public Task<T> TakeData();
    }
}
