using AnimeDesktop.Base;
using AnimeDesktop.DB;
using AnimeDesktop.Shiki;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ShikimoriSharp;

namespace AnimeDesktop.Init.DI
{
    public class ClientInstanceInitter : IDIContainerInitter
    {
        public IServiceCollection Init(IServiceCollection services)
        {

            services.AddSingleton<DBClient>();
            services.AddSingleton<IClient<DbContext>, DBClient>(s => s.GetRequiredService<DBClient>());

            services.AddSingleton<ClientShiki>();
            services.AddSingleton<IClient<ShikimoriClient>, ClientShiki>(s => s.GetRequiredService<ClientShiki>());

            return services;
        }
    }
}
