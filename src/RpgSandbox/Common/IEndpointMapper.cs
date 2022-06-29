namespace RpgSandbox.Common;

public interface IEndpointMapper
{
    IEndpointRouteBuilder MapEndpoints(IEndpointRouteBuilder builder);
}