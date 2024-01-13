using AnimeDesktop.Base;
using AnimeDesktop.DB.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace AnimeDesktop.DB
{
    class DBClient: DbContext, IClient<DbContext>
    {
        public DbContext Instance => this;

        public DbSet<Anime> Anime { get; set; }
        public DbSet<UserRating> UserRating { get; set; }
        public DbSet<WatchedAnime> WatchedAnime { get; set;}
        public DbSet<PlannedAnime> PlannedAnime { get; set;}
        public DbSet<AbandonedAnime> AbandonedAnime { get;set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("DB/appsecrets.json")
                .Build();

            optionsBuilder.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
        }
    }
}
