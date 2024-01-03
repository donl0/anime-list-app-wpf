using AnimeDesktop.Commands;
using AnimeDesktop.Extensions;
using AnimeDesktop.Model;
using AnimeDesktop.Model.Bookmarks;
using AnimeDesktop.Navigation;
using AnimeDesktop.Shiki;
using AnimeDesktop.View;
using AnimeDesktop.ViewModel;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ShikimoriSharp;
using ShikimoriSharp.Classes;

namespace AnimeDesktop.Init
{
    internal class DIInitter : IInitter<IServiceProvider>
    {
        public static IHost AppHost { get; private set; }

        public IServiceProvider Instance => AppHost.Services;

        public DIInitter() {
            InitHost();
        }

        public async void Init()
        {
            await AppHost!.StartAsync();
        }

        public async void Deactivate()
        {
            await AppHost!.StopAsync();
        }

        private void InitHost() {
            AppHost = Host.CreateDefaultBuilder().ConfigureServices((hostContext, services) =>
            {

                services.AddSingleton<INavigationStore, NavigationStore>();
                services.AddSingleton<ClientShiki>();
                services.AddSingleton<IShikiImageRuler, ShikiImageRuler>();

                services.AddSingleton<IDrawableMakerBuilder, DrawableMakerBuilder>(s => new DrawableMakerBuilder(s.GetRequiredService<AnimeIDModel>()));

                services.AddSingleton<OpenAnimeWindowCommand>();

                services.AddTransient<BaseModel<List<Anime>, ClientShiki, ShikimoriClient>, TopHundredModel>(s => new TopHundredModel(s.GetRequiredService<ClientShiki>()));
                services.AddTransient<AnimeIDModel>(s => new AnimeIDModel(s.GetRequiredService<ClientShiki>()));

                services.AddSingleton<BaseAnimeListViewModel, TopHundredViewModel>();

                services.AddTransient<UserPlannedModel>();
                services.AddTransient<UserWatchedModel>();

                services.AddSingleton<MainWindowViewModel>();
                services.AddSingleton<UserBookmarksViewModel>(s => new UserBookmarksViewModel(
                    s.GetRequiredService<UserWatchedModel>(), 
                    s.GetRequiredService<OpenAnimeWindowCommand>(),
                    s.GetRequiredService<ShikiImageRuler>()
                    ));

                services.AddSingleton<TopHundredView>(s => new TopHundredView() { 
                    DataContext = s.GetRequiredService<TopHundredViewModel>()
                });

                services.AddSingleton<MainWindow>(s => new MainWindow()
                {
                    DataContext = s.GetRequiredService<MainWindowViewModel>()
                });

                services.AddSingleton<UserBookmarksControl>(s => new UserBookmarksControl
                {
                    DataContext = s.GetRequiredService<UserBookmarksViewModel>()
                });


            }
            ).Build();
        }
    }
}
