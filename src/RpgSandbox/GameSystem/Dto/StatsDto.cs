namespace RpgSandbox.GameSystem.Dto;

public record StatsDto
{
    public int Attack { get; set; }
    public int Constitution { get; set; }
    public int Intellect { get; set; }
    public int Resilience { get; set; }
    public int MaxHp { get; set; }
    public int MaxMp { get; set; }
}