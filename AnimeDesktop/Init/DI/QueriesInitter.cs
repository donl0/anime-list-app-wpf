using AnimeDesktop.Model;
using AnimeDesktop.Shiki;
using Microsoft.Extensions.DependencyInjection;
using ShikimoriSharp.Classes;
using ShikimoriSharp;
using AnimeDesktop.Model.Bookmarks;
using AnimeDesktop.Queries.Bookmarks;

namespace AnimeDesktop.Init.DI
{
    public class QueriesInitter : IDIContainerInitter
    {
        public IServiceCollection Init(IServiceCollection services)
        {

            services.AddTransient<AnimeWithNameQuery>();

            services.AddTransient<BaseTakeDataQuery<List<Anime>, ShikimoriClient>, TopHundredQuery>(s => s.GetRequiredService<TopHundredQuery>());

            services.AddTransient<TopHundredQuery>();

            services.AddTransient<ITakeDataQuery<List<Anime>>, TopHundredQuery>(s => s.GetRequiredService<TopHundredQuery>());

            services.AddTransient<AnimeIDQuery>();

            services.AddTransient<UserPlannedQuery>();
            services.AddTransient<UserWatchedQuery>();
            services.AddTransient<UserAbandonedQuerry>();

            return services;
        }
    }
}
