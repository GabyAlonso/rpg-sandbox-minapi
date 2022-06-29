namespace RpgSandbox.Common;

public static class IQueryableExtensions
{
    public static IQueryable<T> Paginate<T>(this IQueryable<T> query, int pageNum, int pageSize)
    {
        return query.Skip((pageNum - 1) * pageSize).Take(pageSize);
    }
}