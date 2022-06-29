namespace RpgSandbox.PlayerArea.Dto;

public record HeroListDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string ImageUrl { get; set; }
    public int Level { get; set; }
    public string Class { get; set; }
    public string ClassImageUrl { get; set; }
}