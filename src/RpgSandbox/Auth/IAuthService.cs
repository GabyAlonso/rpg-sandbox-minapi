using RpgSandbox.Auth.Dto;

namespace RpgSandbox.Auth;

public interface IAuthService
{
    Task<IResult> SignUp(SignUpDto signUpInfo);
    Task<IResult> Login(LoginDto loginInfo);
}