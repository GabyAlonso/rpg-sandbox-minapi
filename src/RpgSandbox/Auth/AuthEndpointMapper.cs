using RpgSandbox.Auth.Dto;
using RpgSandbox.Common;

namespace RpgSandbox.Auth;

public class AuthEndpointMapper : IEndpointMapper
{
    public IEndpointRouteBuilder MapEndpoints(IEndpointRouteBuilder builder)
    {
        builder
            .MapPost("/signup", async (IAuthService svc, SignUpDto signUpInfo) => await svc.SignUp(signUpInfo))
            .AllowAnonymous()
            .WithName(nameof(IAuthService.SignUp))
            .WithTags("Auth");
        
        builder
            .MapPost("/login", async (IAuthService svc, LoginDto loginInfo) => await svc.Login(loginInfo))
            .AllowAnonymous()
            .WithName(nameof(IAuthService.Login))
            .WithTags("Auth");
        
        return builder;
    }
}