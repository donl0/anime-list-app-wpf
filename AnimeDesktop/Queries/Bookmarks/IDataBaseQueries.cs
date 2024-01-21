
namespace AnimeDesktop.DB.Model
{
    public interface IDataBaseQueries
    {
        Task<bool> CheckIfAnimeExist<T>(long id) where T : class, IAnimeHolder;
        Task<List<long>> TakeAll<T>() where T : class, IAnimeHolder;
        Task<bool> TryAddAnimeAsync<T>(long animeId) where T : class, IAnimeHolder, new();
        Task<bool> TryRemoveAnime<T>(long id) where T : class, IAnimeHolder;
    }
}