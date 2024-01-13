using AnimeDesktop.Model;
using AnimeDesktop.Servises;
using AnimeDesktop.Servises.DSRuler.Description;
using AnimeDesktop.Servises.DSRuler;
using AnimeDesktop.ViewModel;
using Microsoft.Extensions.DependencyInjection;
using AnimeDesktop.Servises.DrawableMarkerBuilder;
using AnimeDesktop.Model.Navigation;
using ShikimoriSharp.Classes;

namespace AnimeDesktop.Init.DI
{
    public class ServicesInitter : IDIContainerInitter
    {
        public IServiceCollection Init(IServiceCollection services) {
            services.AddTransient<NavigationService<TopHundredViewModel>, NavigationService<TopHundredViewModel>>();
            services.AddTransient<NavigationService<UserBookmarksViewModel>, NavigationService<UserBookmarksViewModel>>();
            services.AddTransient<NavigationService<SearchAnimesViewModel>, NavigationService<SearchAnimesViewModel>>();

            services.AddSingleton<INavigationStore, NavigationStore>(s => new NavigationStore(s.GetRequiredService<TopHundredViewModel>()));
            
            services.AddTransient<ShikiImageRuler>();
            services.AddTransient<IShikiRuler<List<Anime>>, ShikiImageRuler>(s => s.GetRequiredService<ShikiImageRuler>());

            services.AddSingleton<ShikiDescriptionRulerDirector>();

            services.AddTransient<IDrawableMakerBuilder, DrawableMakerBuilder>(s => new DrawableMakerBuilder(s.GetRequiredService<AnimeIDQuery>()));

            return services;
        }
    }
}
