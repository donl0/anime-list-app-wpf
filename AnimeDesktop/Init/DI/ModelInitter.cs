using AnimeDesktop.ViewModel;
using Microsoft.Extensions.DependencyInjection;
using AnimeDesktop.Model.Commands;
using AnimeDesktop.Model.Navigation.Commands;
using AnimeDesktop.Model.Commands.BookmarkModelUpdater;

namespace AnimeDesktop.Init.DI
{
    public class ModelInitter : IDIContainerInitter
    {
        public IServiceCollection Init(IServiceCollection services)
        {
            services.AddTransient<NavigateCommand<TopHundredViewModel>, NavigateCommand<TopHundredViewModel>>();
            services.AddTransient<NavigateCommand<UserBookmarksViewModel>, NavigateCommand<UserBookmarksViewModel>>();
            services.AddTransient<NavigateCommand<SearchAnimesViewModel>, NavigateCommand<SearchAnimesViewModel>>();

            services.AddTransient<OpenAnimeWindowCommand>();

            services.AddTransient<SearchAnimeCommand<SearchAnimesViewModel>, SearchAnimeCommand<SearchAnimesViewModel>>();

            services.AddTransient<PlannedSetterCommand>();
            services.AddTransient<AbandonedSetterCommand>();
            services.AddTransient<WatchedSetterCommand>();

            services.AddSingleton<BookmarksCommandsContainer>(s => new BookmarksCommandsContainer(
                s.GetRequiredService<WatchedSetterCommand>(),
                s.GetRequiredService<PlannedSetterCommand>(),
                s.GetRequiredService<AbandonedSetterCommand>()
                ));

            return services;
        }
    }
}
