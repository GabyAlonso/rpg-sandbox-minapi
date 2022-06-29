namespace RpgSandbox.GameSystem.Entities;

public class Class
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
    
    public int InitialAttack { get; set; }
    public int InitialConstitution { get; set; }
    public int InitialIntellect { get; set; }
    public int InitialResilience { get; set; }
    public int InitialMaxHp { get; set; }
    public int InitialMaxMp { get; set; }
    
    public HashSet<Ability> Abilities { get; set; }
    public HashSet<PartyRole> PartyRoles { get; set; }
}