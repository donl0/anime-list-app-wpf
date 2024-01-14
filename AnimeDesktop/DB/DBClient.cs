using AnimeDesktop.Base;
using AnimeDesktop.DB.Model;
using AnimeDesktop.Secrets;
using Microsoft.EntityFrameworkCore;

namespace AnimeDesktop.DB
{
    public class DBClient: DbContext, IClient<DbContext>
    {
        public DbContext Instance => this;

        public DbSet<UserRating> UserRating { get; set; }
        public DbSet<WatchedAnime> WatchedAnime { get; set;}
        public DbSet<PlannedAnime> PlannedAnime { get; set;}
        public DbSet<AbandonedAnime> AbandonedAnime { get;set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(new DbConnection().GetConnection());
        }
    }
}
