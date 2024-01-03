using ShikimoriSharp;

namespace AnimeDesktop.Shiki
{
    public interface IClient<T>
    {
        public T Instance { get;}
    }
}