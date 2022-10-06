namespace SonicGuide.Rcl.Components;

public partial class AllGamesComponent
{
    protected override async Task OnInitializedAsync()
    {
        if (State.GameData is not null)
        {
            return;
        }
        State.GameData = await GameDataService.GetGameDataAsync();
    }
}
