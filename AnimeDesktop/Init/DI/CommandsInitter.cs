using AnimeDesktop.Navigation.Commands;
using AnimeDesktop.ViewModel;
using Microsoft.Extensions.DependencyInjection;
using AnimeDesktop.Commands;

namespace AnimeDesktop.Init.DI
{
    public class CommandsInitter : IDIContainerInitter
    {
        public IServiceCollection Init(IServiceCollection services)
        {

            services.AddSingleton<NavigateCommand<TopHundredViewModel>, NavigateCommand<TopHundredViewModel>>();
            services.AddSingleton<NavigateCommand<UserBookmarksViewModel>, NavigateCommand<UserBookmarksViewModel>>();
            services.AddSingleton<NavigateCommand<SearchAnimesViewModel>, NavigateCommand<SearchAnimesViewModel>>();

            services.AddSingleton<OpenAnimeWindowCommand>();

            services.AddSingleton<SearchAnimeCommand<SearchAnimesViewModel>, SearchAnimeCommand<SearchAnimesViewModel>>();

            return services;
        }
    }
}
