using AnimeDesktop.View;
using AnimeDesktop.ViewModel;
using Microsoft.Extensions.DependencyInjection;

namespace AnimeDesktop.Init.DI
{
    public class ViewInitter : IDIContainerInitter
    {
        public IServiceCollection Init(IServiceCollection services)
        {
            services.AddSingleton(s => new MainWindow()
            {
                DataContext = s.GetRequiredService<MainWindowViewModel>()
            });

            services.AddSingleton<CertainAnimeView>(s => new CertainAnimeView()
            {
                DataContext = s.GetRequiredService<CertainAnimeViewModel>()
            });

            return services;
        }
    }
}
