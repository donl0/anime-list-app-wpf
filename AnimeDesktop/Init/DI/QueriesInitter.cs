using AnimeDesktop.Model;
using AnimeDesktop.Shiki;
using Microsoft.Extensions.DependencyInjection;
using ShikimoriSharp.Classes;
using ShikimoriSharp;
using AnimeDesktop.Model.Bookmarks;

namespace AnimeDesktop.Init.DI
{
    public class QueriesInitter : IDIContainerInitter
    {
        public IServiceCollection Init(IServiceCollection services)
        {

            services.AddTransient<AnimeWithNameQuery>();

            services.AddTransient<BaseTakeDataQuery<List<Anime>, ShikimoriClient>, TopHundredQuery>(s => new TopHundredQuery(s.GetRequiredService<ClientShiki>()));
            services.AddTransient<AnimeIDQuery>();

            services.AddTransient<UserPlannedQuery>();
            services.AddTransient<UserWatchedQuery>();

            return services;
        }
    }
}
