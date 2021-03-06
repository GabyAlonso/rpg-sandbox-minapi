using System.Text.Json.Serialization;

namespace RpgSandbox.Auth.Dto;

public class UserDto
{
    public int Id { get; set; }
    public string Username { get; set; }
    
    [JsonIgnore]
    public string PassHash { get; set; }
}