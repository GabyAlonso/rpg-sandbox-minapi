using RpgSandbox.Common;

namespace RpgSandbox.GameSystem;

public class GameSystemEndpointMapper : IEndpointMapper
{
    public IEndpointRouteBuilder MapEndpoints(IEndpointRouteBuilder builder)
    {
        builder
            .MapGet("/api/game-system/class/ref", async (IClassService svc) => await svc.GetClassList())
            .WithName(nameof(IClassService.GetClassList))
            .WithTags("Class", "ref");
        
        builder
            .MapGet("/api/game-system/class", async (IClassService svc) => await svc.GetClasses())
            .WithName(nameof(IClassService.GetClasses))
            .WithTags("Class");
        
        builder
            .MapGet("/api/game-system/class/{id}", async (IClassService svc, int id) => await svc.GetClass(id))
            .WithName(nameof(IClassService.GetClass))
            .WithTags("Class");

        builder
            .MapGet("/api/game-system/role", async (IClassService svc) => await svc.GetRoles())
            .WithName(nameof(IClassService.GetRoles))
            .WithTags("Role");
        
        builder
            .MapGet("/api/game-system/role/{id}/classes", async (IClassService svc, int id) => await svc.GetClassesByRole(id))
            .WithName(nameof(IClassService.GetClassesByRole))
            .WithTags("Role", "Class");
        
        builder.MapGet("/oops", () =>
        {
            throw new ZombieApocalypseException("ouch");
        });
        
        builder.MapGet("/oops2", () =>
        {
            throw new InvalidCastException("ouch");
        });

        return builder;
    }
}

// public static class ServiceExtensions
// {
//     public static IServiceCollection RegisterGameSystemModule(this IServiceCollection services)
//     {
//         services.AddScoped<IClassService, ClassService>();
//         return services;
//     }
//
//     public static IEndpointRouteBuilder MapGameSystemEndpoints(this IEndpointRouteBuilder builder)
//     {
//         builder
//             .MapGet("/ref/class", async (IClassService svc) => await svc.GetClassList())
//             .WithName(nameof(IClassService.GetClassList))
//             .WithTags("Class", "ref");
//         
//         builder
//             .MapGet("/class", async (IClassService svc) => await svc.GetClasses())
//             .WithName(nameof(IClassService.GetClasses))
//             .WithTags("Class");
//         
//         builder
//             .MapGet("/class/{id}", async (IClassService svc, int id) => await svc.GetClass(id))
//             .WithName(nameof(IClassService.GetClass))
//             .WithTags("Class");
//
//         builder
//             .MapGet("/role", async (IClassService svc) => await svc.GetRoles())
//             .WithName(nameof(IClassService.GetRoles))
//             .WithTags("Role");
//         
//         builder
//             .MapGet("/role/{id}/classes", async (IClassService svc, int id) => await svc.GetClassesByRole(id))
//             .WithName(nameof(IClassService.GetClassesByRole))
//             .WithTags("Role", "Class");
//         
//         builder.MapGet("/oops", () =>
//         {
//             throw new ZombieApocalypseException("ouch");
//         });
//         
//         builder.MapGet("/oops2", () =>
//         {
//             throw new InvalidCastException("ouch");
//         });
//
//         return builder;
//     }
// }