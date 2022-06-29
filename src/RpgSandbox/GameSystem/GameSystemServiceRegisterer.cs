using RpgSandbox.Common;

namespace RpgSandbox.GameSystem;

public class GameSystemServiceRegisterer : IServiceRegisterer
{
    public IServiceCollection RegisterServices(IServiceCollection services)
    {
        services.AddScoped<IClassService, ClassService>();
        return services;
    }
}