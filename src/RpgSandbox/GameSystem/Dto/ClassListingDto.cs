namespace RpgSandbox.GameSystem.Dto;

public record ClassListingDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
}