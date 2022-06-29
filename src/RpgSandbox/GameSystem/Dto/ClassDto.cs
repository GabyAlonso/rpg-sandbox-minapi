namespace RpgSandbox.GameSystem.Dto;

public record ClassDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
    public StatsDto InitialStats { get; set; }
    public List<AbilityDto> Abilities { get; set; }
    public List<string> Roles { get; set; }
}