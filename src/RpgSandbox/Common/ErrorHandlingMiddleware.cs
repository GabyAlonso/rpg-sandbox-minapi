using System.Net;
using RpgSandbox.Common;

namespace RpgSandbox.Common;

public class ErrorHandlingMiddleware
{
    private readonly RequestDelegate _next;

    public ErrorHandlingMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (ZombieApocalypseException ex)
        {
            context.Response.StatusCode = (int) HttpStatusCode.BadRequest;

            await context.Response.WriteAsJsonAsync(new ErrorDto(ex.Message));
        }
        catch (Exception ex)
        {
            context.Response.StatusCode = (int) HttpStatusCode.InternalServerError;

            await context.Response.WriteAsJsonAsync(new { Message = ex.Message, Trace = ex.StackTrace });
        }
    }
}