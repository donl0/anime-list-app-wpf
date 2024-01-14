using AnimeDesktop.Model;
using Microsoft.Extensions.DependencyInjection;
using ShikimoriSharp;
using AnimeDesktop.Model.Bookmarks;
using AnimeDesktop.Queries.Bookmarks;
using AnimeDesktop.DB.Model;

namespace AnimeDesktop.Init.DI
{
    public class QueriesInitter : IDIContainerInitter
    {
        public IServiceCollection Init(IServiceCollection services)
        {

            services.AddTransient<AnimeWithNameQuery>();

            services.AddTransient<BaseTakeDataQuery<List<ShikimoriSharp.Classes.Anime>, ShikimoriClient>, TopHundredQuery>(s => s.GetRequiredService<TopHundredQuery>());

            services.AddTransient<TopHundredQuery>();

            services.AddTransient<ITakeDataQuery<List<ShikimoriSharp.Classes.Anime>>, TopHundredQuery>(s => s.GetRequiredService<TopHundredQuery>());

            services.AddTransient<AnimeIDQuery>();

            services.AddTransient<UserPlannedQuery>();
            services.AddTransient<UserWatchedQuery>();
            services.AddTransient<UserAbandonedQuerry>();

            services.AddTransient<IDataBaseQueries, DataBaseQueries>();

            return services;
        }
    }
}
