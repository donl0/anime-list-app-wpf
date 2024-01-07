using AnimeDesktop.Model;
using AnimeDesktop.Navigation;
using AnimeDesktop.Servises;
using AnimeDesktop.Servises.DSRuler.Description;
using AnimeDesktop.Servises.DSRuler;
using AnimeDesktop.Shiki;
using AnimeDesktop.ViewModel;
using Microsoft.Extensions.DependencyInjection;
using AnimeDesktop.Servises.DrawableMarkerBuilder;

namespace AnimeDesktop.Init.DI
{
    public class ServicesInitter : IDIContainerInitter
    {
        public IServiceCollection Init(IServiceCollection services) {
            services.AddSingleton<NavigationService<TopHundredViewModel>, NavigationService<TopHundredViewModel>>();
            services.AddSingleton<NavigationService<UserBookmarksViewModel>, NavigationService<UserBookmarksViewModel>>();
            services.AddSingleton<NavigationService<SearchAnimesViewModel>, NavigationService<SearchAnimesViewModel>>();

            services.AddSingleton<INavigationStore, NavigationStore>(s => new NavigationStore(s.GetRequiredService<TopHundredViewModel>()));
            services.AddSingleton<ClientShiki>();
            services.AddSingleton<ShikiImageRuler>();
            services.AddSingleton<ShikiDescriptionRulerDirector>();

            services.AddSingleton<IDrawableMakerBuilder, DrawableMakerBuilder>(s => new DrawableMakerBuilder(s.GetRequiredService<AnimeIDModel>()));

            return services;
        }
    }
}
