namespace RpgSandbox.PlayerArea.Dto;

public record HeroViewDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string ImageUrl { get; set; }
    public int Level { get; set; }
    public HeroStatsDto Stats { get; set; }
    public string Class { get; set; }
    public string ClassImageUrl { get; set; }
}

public record HeroStatsDto
{
    public int Attack { get; set; }
    public int Constitution { get; set; }
    public int Intellect { get; set; }
    public int Resilience { get; set; }
    public int MaxHp { get; set; }
    public int MaxMp { get; set; }
}