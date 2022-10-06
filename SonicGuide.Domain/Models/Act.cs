namespace SonicGuide.Domain.Models;

public class Act
{
    [JsonPropertyName("name")]
    public string? name { get; set; }

    [JsonPropertyName("order")]
    public int? order { get; set; }

    [JsonPropertyName("image")]
    public string? image { get; set; }

    [JsonPropertyName("bosses")]
    public Boss[]? bosses { get; set; }
}
