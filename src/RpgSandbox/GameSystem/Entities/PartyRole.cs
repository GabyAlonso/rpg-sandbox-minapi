namespace RpgSandbox.GameSystem.Entities;

public class PartyRole
{
    public int Id { get; set; }
    public string Name { get; set; }
    public HashSet<Class> Classes { get; set; }
}