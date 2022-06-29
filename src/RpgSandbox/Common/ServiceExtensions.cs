namespace RpgSandbox.Common;

public static class ServiceExtensions
{
    public static IServiceCollection RegisterServices(this IServiceCollection services, Type markerType)
    {
        foreach (var s in GetByType<IServiceRegisterer>(markerType))
        {
            s.RegisterServices(services);
        }
        
        return services;
    }

    public static IEndpointRouteBuilder MapEndpoints(this IEndpointRouteBuilder builder, Type markerType)
    {
        foreach (var m in GetByType<IEndpointMapper>(markerType))
        {
            m.MapEndpoints(builder);
        }
        
        return builder;
    }

    private static IEnumerable<T> GetByType<T>(Type markerType)
    {
        return markerType.Assembly.GetTypes()
            .Where(t => typeof(T).IsAssignableFrom(t) && !t.IsInterface)
            .Select(t => (T)Activator.CreateInstance(t));
    }
}