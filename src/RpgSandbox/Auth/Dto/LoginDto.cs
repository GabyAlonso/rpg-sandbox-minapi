using System.Text.Json.Serialization;

namespace RpgSandbox.Auth.Dto;

public class LoginDto
{
    public string Email { get; set; }
    public string Password { get; set; }
}