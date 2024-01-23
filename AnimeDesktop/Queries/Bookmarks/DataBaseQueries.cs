using AnimeDesktop.Base;
using Microsoft.EntityFrameworkCore;

namespace AnimeDesktop.DB.Model
{
    public sealed class DataBaseQueries : IDataBaseQueries
    {
        private IClient<DbContext> _client;

        public DataBaseQueries(IClient<DbContext> client)
        {
            _client = client;
        }

        public async Task<bool> CheckIfAnimeExistAsync<T>(long id) where T : class, IAnimeHolder
        {
            DbSet<T> dbSet = _client.Instance.Set<T>();

            bool exists = await dbSet.AnyAsync(a => a.AnimeId == id);

            return exists;
        }

        public async Task<bool> TryRemoveAnimeAsync<T>(long id) where T : class, IAnimeHolder
        {
            DbSet<T> dbSet = _client.Instance.Set<T>();

            T animeToDelete = await dbSet.SingleOrDefaultAsync(a => a.AnimeId == id);

            if (animeToDelete != null)
            {
                dbSet.Remove(animeToDelete);
                await _client.Instance.SaveChangesAsync();
                return true;
            }

            return false;
        }

        public async Task<bool> TryAddAnimeAsync<T>(long animeId) where T : class, IAnimeHolder, new()
        {
            DbSet<T> dbSet = _client.Instance.Set<T>();

            if (!await CheckIfAnimeExistAsync<T>(animeId))
            {
                T animeHolder = new T
                {
                    AnimeId = animeId
                };

                await dbSet.AddAsync(animeHolder);
                await _client.Instance.SaveChangesAsync();

                return true;
            }

            return false;
        }

        public async Task<List<long>> TakeAllAsync<T>() where T : class, IAnimeHolder
        {
            DbSet<T> dbSet = _client.Instance.Set<T>();
            List<T> allRecords = await dbSet.ToListAsync();

            List<long> result = new List<long>();

            foreach (T record in allRecords) { 
                result.Add(record.AnimeId);
            }

            return result;
        }
    }
}
