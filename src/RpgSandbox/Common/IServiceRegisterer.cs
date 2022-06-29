namespace RpgSandbox.Common;

public interface IServiceRegisterer
{
    IServiceCollection RegisterServices(IServiceCollection services);
}