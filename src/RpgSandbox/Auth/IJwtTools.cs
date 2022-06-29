namespace RpgSandbox.Auth;

public interface IJwtTools
{
    string GenerateToken(int id);
    int? ValidateToken(string token);
}