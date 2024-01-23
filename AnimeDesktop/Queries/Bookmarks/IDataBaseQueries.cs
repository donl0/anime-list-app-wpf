
namespace AnimeDesktop.DB.Model
{
    public interface IDataBaseQueries
    {
        Task<bool> CheckIfAnimeExistAsync<T>(long id) where T : class, IAnimeHolder;
        Task<List<long>> TakeAllAsync<T>() where T : class, IAnimeHolder;
        Task<bool> TryAddAnimeAsync<T>(long animeId) where T : class, IAnimeHolder, new();
        Task<bool> TryRemoveAnimeAsync<T>(long id) where T : class, IAnimeHolder;
    }
}