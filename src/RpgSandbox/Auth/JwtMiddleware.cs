namespace RpgSandbox.Auth;

public class JwtMiddleware
{
    private readonly RequestDelegate _next;

    public JwtMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context, IJwtTools jwtTools)
    {
        var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
        var userId = jwtTools.ValidateToken(token);
        if (userId != null)
        {
            context.Items["UserId"] = userId.Value;
        }

        await _next(context);
    }
}