namespace AnimeDesktop.Base
{
    public interface IClient<T>
    {
        public T Instance { get; }
    }
}