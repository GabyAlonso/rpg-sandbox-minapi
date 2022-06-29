using Microsoft.AspNetCore.Mvc;
using RpgSandbox.Common;
using RpgSandbox.PlayerArea.Dto;

namespace RpgSandbox.PlayerArea;

public class PlayerAreaEndpointMapper : IEndpointMapper
{
    public IEndpointRouteBuilder MapEndpoints(IEndpointRouteBuilder builder)
    {
        builder.MapGet("/heroes", async (IHeroService svc, HttpContext context, int pageNum, int pageSize, int? classId, string name) =>
                await svc.GetHeroes(context.GetUserId(), pageNum, pageSize, classId, name))
            .WithName(nameof(IHeroService.GetHeroes))
            .WithTags("Hero");
        
        return builder;
    }
}