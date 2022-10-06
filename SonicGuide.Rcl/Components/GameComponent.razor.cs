namespace SonicGuide.Rcl.Components;

public partial class GameComponent
{
    [Parameter, EditorRequired] public Game? Game { get; set; }

    private async Task SpeakGameName()
    {
        if (Game?.name is null)
        {
            return;
        }
        await JsInterop.SpeakTextAsync(Game.name);
    }

    private bool hideImage = false;

    private void OnImgError() => hideImage = true;
}
