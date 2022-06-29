using RpgSandbox.Common;

namespace RpgSandbox.Auth;

public class AuthServiceRegisterer : IServiceRegisterer
{
    public IServiceCollection RegisterServices(IServiceCollection services)
    {
        return services
            .AddScoped<IJwtTools, JwtTools>()
            .AddScoped<IAuthService, AuthService>();
    }
}