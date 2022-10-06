namespace SonicGuide.Domain.Models;

public class Game
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("order")]
    public int? Order { get; set; }

    [JsonPropertyName("image")]
    public string? Image { get; set; }

    [JsonPropertyName("zones")]
    public Zone[]? Zones { get; set; }
}
