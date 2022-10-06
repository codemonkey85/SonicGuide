namespace SonicGuide.Domain.Models;

public class GameData
{
    [JsonPropertyName("games")]
    public Game[]? games { get; set; }
}
