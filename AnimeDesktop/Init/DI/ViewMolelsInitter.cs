using AnimeDesktop.Model;
using AnimeDesktop.Servises.DSRuler;
using AnimeDesktop.ViewModel;
using Microsoft.Extensions.DependencyInjection;
using AnimeDesktop.Commands;

namespace AnimeDesktop.Init.DI
{
    public class ViewMolelsInitter : IDIContainerInitter
    {
        public IServiceCollection Init(IServiceCollection services)
        {

            services.AddSingleton<AnimeWithNameModel>();
            services.AddSingleton<SearchAnimesViewModel>();

            services.AddSingleton<ISearchModel>(s => s.GetRequiredService<SearchAnimesViewModel>());
            services.AddSingleton<TopHundredViewModel>();

            services.AddSingleton<MainWindowViewModel>();

            services.AddSingleton(s => new UserBookmarksViewModel(
                s.GetRequiredService<UserWatchedModel>(),
                s.GetRequiredService<OpenAnimeWindowCommand>(),
                s.GetRequiredService<ShikiImageRuler>()
                ));

            services.AddSingleton<HeaderNavigationViewModel>();

            services.AddSingleton<CertainAnimeViewModel>();
            services.AddSingleton<ICertainAnimeViewModel>(s => s.GetRequiredService<CertainAnimeViewModel>());

            return services;
        }
    }
}
