using AnimeDesktop.Model;
using AnimeDesktop.Shiki;
using Microsoft.Extensions.DependencyInjection;
using ShikimoriSharp.Classes;
using ShikimoriSharp;
using AnimeDesktop.Model.Bookmarks;
using AnimeDesktop.View;

namespace AnimeDesktop.Init.DI
{
    public class ModelsInitter : IDIContainerInitter
    {
        public IServiceCollection Init(IServiceCollection services)
        {

            services.AddSingleton<AnimeWithNameModel>();

            services.AddSingleton<BaseModel<List<Anime>, ClientShiki, ShikimoriClient>, TopHundredModel>(s => new TopHundredModel(s.GetRequiredService<ClientShiki>()));
            services.AddSingleton(s => new AnimeIDModel(s.GetRequiredService<ClientShiki>()));

            services.AddSingleton<UserPlannedModel>();
            services.AddSingleton<UserWatchedModel>();

            return services;
        }
    }
}
