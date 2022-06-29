using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RpgSandbox.Auth.Dto;
using RpgSandbox.Auth.Entities;
using RpgSandbox.Common;

namespace RpgSandbox.Auth;

public class AuthService : IAuthService
{
    private readonly IMapper _mapper;
    private readonly RpgDataContext _context;
    private readonly IJwtTools _jwtTools;

    public AuthService(IMapper mapper, RpgDataContext context, IJwtTools jwtTools)
    {
        _mapper = mapper;
        _context = context;
        _jwtTools = jwtTools;
    }

    public async Task<IResult> SignUp(SignUpDto signUpInfo)
    {
        var usr = await _context.Users.FirstOrDefaultAsync(u =>
            u.Email == signUpInfo.Email || u.ScreenName == signUpInfo.ScreenName);
        
        if(usr != null)
        {
            var msg = usr.Email == signUpInfo.Email
                ? $"Email {signUpInfo.Email} is already registered"
                : $"Username {signUpInfo.ScreenName} is already registered";

            return Results.BadRequest(new ErrorDto(msg));
        }

        var user = _mapper.Map<User>(signUpInfo);
        
        user.PassHash = BCrypt.Net.BCrypt.HashPassword(signUpInfo.Password);
        
        _context.Users.Add(user);
        await _context.SaveChangesAsync();

        return Results.NoContent();
    }

    public async Task<IResult> Login(LoginDto loginInfo)
    {
        var user = await  _context.Users.SingleOrDefaultAsync(x => x.Email == loginInfo.Email);

        if (user == null || !BCrypt.Net.BCrypt.Verify(loginInfo.Password, user.PassHash))
        {
            return Results.BadRequest(new ErrorDto("Username or password is incorrect"));
        }

        var response = _mapper.Map<LoginResponseDto>(user);
        response.Token = _jwtTools.GenerateToken(user.Id);
        
        return Results.Ok(response);
    }
}