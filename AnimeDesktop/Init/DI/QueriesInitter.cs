using AnimeDesktop.Model;
using Microsoft.Extensions.DependencyInjection;
using ShikimoriSharp;
using AnimeDesktop.Model.Bookmarks;
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

            services.AddTransient<AnimeWithIDQuery>();


            services.AddTransient<IDataBaseQueries, DataBaseQueries>();

            services.AddTransient<TakeAllFromUserBookmark<PlannedAnime>, TakeAllFromUserBookmark<PlannedAnime>>();
            services.AddTransient<TakeAllFromUserBookmark<WatchedAnime>, TakeAllFromUserBookmark<WatchedAnime>>();
            services.AddTransient<TakeAllFromUserBookmark<AbandonedAnime>, TakeAllFromUserBookmark<AbandonedAnime>>();

            return services;
        }
    }
}
