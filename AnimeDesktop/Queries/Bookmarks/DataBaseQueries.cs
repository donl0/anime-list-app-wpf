﻿using AnimeDesktop.Base;
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

        public bool CheckIfAnimeExist<T>(long id) where T : class, IAnimeHolder
        {
            DbSet<T> dbSet = _client.Instance.Set<T>();

            bool exists = dbSet.Any(a => a.AnimeId == id);

            return exists;
        }

        public bool TryRemoveAnime<T>(long id) where T : class, IAnimeHolder
        {
            DbSet<T> dbSet = _client.Instance.Set<T>();

            T animeToDelete = dbSet.SingleOrDefault(a => a.AnimeId == id);

            if (animeToDelete != null)
            {
                dbSet.Remove(animeToDelete);
                _client.Instance.SaveChanges();
                return true;
            }

            return false;
        }

        public bool TryAddAnime<T>(long animeId) where T : class, IAnimeHolder, new()
        {
            DbSet<T> dbSet = _client.Instance.Set<T>();

            T animeToAdd = dbSet.SingleOrDefault(a => a.AnimeId == animeId);

            if (animeToAdd == null)
            {
                T animeHolder = new T
                {
                    AnimeId = animeId
                };

                dbSet.Add(animeHolder);
                _client.Instance.SaveChanges();

                return true;
            }

            return false;
        }
    }
}
