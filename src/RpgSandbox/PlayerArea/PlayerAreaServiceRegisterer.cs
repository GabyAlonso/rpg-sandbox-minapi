using RpgSandbox.Common;

namespace RpgSandbox.PlayerArea;

public class PlayerAreaServiceRegisterer : IServiceRegisterer
{
    public IServiceCollection RegisterServices(IServiceCollection services)
    {
        return services.AddScoped<IHeroService, HeroService>();
    }
}