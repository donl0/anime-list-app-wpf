using AnimeDesktop.ViewModel;
using Microsoft.Extensions.DependencyInjection;
using AnimeDesktop.Model.Commands;
using AnimeDesktop.Model.Navigation.Commands;

namespace AnimeDesktop.Init.DI
{
    public class CommandsInitter : IDIContainerInitter
    {
        public IServiceCollection Init(IServiceCollection services)
        {
            services.AddTransient<NavigateCommand<TopHundredViewModel>, NavigateCommand<TopHundredViewModel>>();
            services.AddTransient<NavigateCommand<UserBookmarksViewModel>, NavigateCommand<UserBookmarksViewModel>>();
            services.AddTransient<NavigateCommand<SearchAnimesViewModel>, NavigateCommand<SearchAnimesViewModel>>();

            services.AddTransient<OpenAnimeWindowCommand>();

            services.AddTransient<SearchAnimeCommand<SearchAnimesViewModel>, SearchAnimeCommand<SearchAnimesViewModel>>();

            return services;
        }
    }
}
