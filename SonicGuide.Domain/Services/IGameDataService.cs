namespace SonicGuide.Domain.Services;

public interface IGameDataService
{
    Task<GameData?> GetGameDataAsync();
}
