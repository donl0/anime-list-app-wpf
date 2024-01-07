using Microsoft.Extensions.DependencyInjection;

namespace AnimeDesktop.Init.DI
{
    public interface IDIContainerInitter
    {
        IServiceCollection Init(IServiceCollection services);
    }
}