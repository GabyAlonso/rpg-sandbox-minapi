using System.Text.Json.Serialization;

namespace RpgSandbox.Auth.Entities;

public class User
{
    public int Id { get; set; }
    public string Email { get; set; }
    public string ScreenName { get; set; }
    public string PassHash { get; set; }
}