using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using RpgSandbox.Common;

namespace RpgSandbox.Auth;

public class JwtTools : IJwtTools
{
    private readonly AppSettings _settings;

    public JwtTools(IOptions<AppSettings> settings)
    {
        _settings = settings.Value;
    }

    public string GenerateToken(int id)
    {
        var key = Encoding.UTF8.GetBytes(_settings.Secret);
       
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new [] {
                new Claim("Id", id.ToString())
            }),
            Expires = DateTime.Now.AddHours(5),
            Audience = _settings.Audience,
            Issuer = _settings.Issuer,
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha512)
        };
        
        var jwtTokenHandler = new JwtSecurityTokenHandler();
        var token = jwtTokenHandler.CreateToken(tokenDescriptor);
        return jwtTokenHandler.WriteToken(token);
    }
    
    public int? ValidateToken(string token)
    {
        if (token == null)
        {
            return null;
        }

        var key = Encoding.ASCII.GetBytes(_settings.Secret);
        try
        {
            new JwtSecurityTokenHandler().ValidateToken(token, new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(key),
                ValidateIssuer = false,
                ValidateAudience = false,
                ClockSkew = TimeSpan.Zero
            }, out var validatedToken);

            return int.Parse(((JwtSecurityToken) validatedToken).Claims.First(x => x.Type == "Id").Value);
        }
        catch
        {
            return null;
        }
    }
}