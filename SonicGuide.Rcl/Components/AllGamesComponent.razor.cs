namespace SonicGuide.Rcl.Components;

public partial class AllGamesComponent
{
    private GameData? GameData { get; set; } = new();

    protected override async Task OnInitializedAsync()
    {
        GameData = await GameDataService.GetGameDataAsync();
    }
}
