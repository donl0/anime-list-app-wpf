
namespace AnimeDesktop.DB.Model
{
    public interface IDataBaseQueries
    {
        bool CheckIfAnimeExist<T>(long id) where T : class, IAnimeHolder;
        List<long> TakeAll<T>() where T : class, IAnimeHolder;
        bool TryAddAnime<T>(long animeId) where T : class, IAnimeHolder, new();
        bool TryRemoveAnime<T>(long id) where T : class, IAnimeHolder;
    }
}