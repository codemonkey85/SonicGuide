namespace SonicGuide.Domain.Models;

public class Game
{
    [JsonPropertyName("name")]
    public string? name { get; set; }

    [JsonPropertyName("order")]
    public int? order { get; set; }

    [JsonPropertyName("image")]
    public string? image { get; set; }

    [JsonPropertyName("zones")]
    public Zone[]? zones { get; set; }
}
