namespace SonicGuide.Rcl.Services;

public record GameDataService(HttpClient HttpClient) : IGameDataService
{
    public async Task<GameData?> GetGameDataAsync() =>
        await HttpClient.GetFromJsonAsync<GameData?>("_content/SonicGuide.Rcl/data/gamedata.json");
}
