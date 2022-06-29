namespace RpgSandbox.GameSystem.Entities;

public class Ability
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int BaseCost { get; set; }
    public int UnlockedAtLevel { get; set; }
    public int ClassId { get; set; }
    public Class Class { get; set; }
}