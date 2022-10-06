namespace SonicGuide.Domain.Models;

public class Zone
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("order")]
    public int? Order { get; set; }

    [JsonPropertyName("image")]
    public string? Image { get; set; }

    [JsonPropertyName("acts")]
    public Act[]? Acts { get; set; }

    [JsonPropertyName("bosses")]
    public Boss[]? Bosses { get; set; }
}
