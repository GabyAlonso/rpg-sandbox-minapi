using RpgSandbox.Auth.Entities;
using RpgSandbox.GameSystem.Entities;

namespace RpgSandbox.PlayerArea.Entities;

public class Hero
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string ImageUrl { get; set; }
    
    public int Level { get; set; }
    public int Attack { get; set; }
    public int Constitution { get; set; }
    public int Intellect { get; set; }
    public int Resilience { get; set; }
    public int MaxHp { get; set; }
    public int MaxMp { get; set; }
    
    public int ClassId { get; set; }
    public Class Class { get; set; }
    
    public int UserId { get; set; }
    public User User { get; set; }
}