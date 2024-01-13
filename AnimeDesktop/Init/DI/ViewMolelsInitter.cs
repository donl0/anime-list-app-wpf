using AnimeDesktop.Model;
using AnimeDesktop.Servises.DSRuler;
using AnimeDesktop.ViewModel;
using Microsoft.Extensions.DependencyInjection;
using AnimeDesktop.Model.Commands;

namespace AnimeDesktop.Init.DI
{
    public class ViewMolelsInitter : IDIContainerInitter
    {
        public IServiceCollection Init(IServiceCollection services)
        {

            services.AddSingleton<SearchAnimesViewModel>();

            services.AddSingleton<ISearchModel>(s => s.GetRequiredService<SearchAnimesViewModel>());
            services.AddSingleton<TopHundredViewModel>();

            services.AddSingleton<MainWindowViewModel>();

            services.AddSingleton<UserBookmarksViewModel>();

            services.AddSingleton<HeaderNavigationViewModel>();

            services.AddSingleton<CertainAnimeViewModel>();
            services.AddSingleton<ICertainAnimeViewModel>(s => s.GetRequiredService<CertainAnimeViewModel>());

            return services;
        }
    }
}
