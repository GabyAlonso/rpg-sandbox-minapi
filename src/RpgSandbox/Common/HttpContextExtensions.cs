namespace RpgSandbox.Common;

public static class HttpContextExtensions
{
    public static int GetUserId(this HttpContext context)
    {
        if (context == null) return 0;
        var id = context.Items["UserId"];
        return id != null ? (int) id : 0;

    }
}