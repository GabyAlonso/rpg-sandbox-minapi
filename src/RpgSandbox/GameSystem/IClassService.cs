namespace RpgSandbox.GameSystem;

public interface IClassService
{
    Task<IResult> GetClassList();
    Task<IResult> GetClasses();
    Task<IResult> GetClass(int id);
    Task<IResult> GetRoles();
    Task<IResult> GetClassesByRole(int roleId);
}