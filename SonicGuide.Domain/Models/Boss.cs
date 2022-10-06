namespace SonicGuide.Domain.Models;

public class Boss
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("order")]
    public int? Order { get; set; }

    [JsonPropertyName("image")]
    public string? Image { get; set; }
}
