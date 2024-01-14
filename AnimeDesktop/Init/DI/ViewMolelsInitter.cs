using AnimeDesktop.Model;
using AnimeDesktop.ViewModel;
using Microsoft.Extensions.DependencyInjection;

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

            services.AddSingleton<IBookmarksModel, UserBookmarksViewModel>(s => s.GetRequiredService<UserBookmarksViewModel>());

            return services;
        }
    }
}
