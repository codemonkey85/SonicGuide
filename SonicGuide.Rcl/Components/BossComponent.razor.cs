namespace SonicGuide.Rcl.Components;

public partial class BossComponent
{
    [Parameter, EditorRequired] public Game? Game { get; set; }

    [Parameter, EditorRequired] public Zone? Zone { get; set; }

    [Parameter, EditorRequired] public Act? Act { get; set; }

    [Parameter, EditorRequired] public Boss? Boss { get; set; }

    private async Task SpeakBossName()
    {
        if (Boss?.Name is null)
        {
            return;
        }
        await JsInterop.SpeakTextAsync(Boss.Name);
    }

    private bool hideImage = false;

    private void OnImgError() => hideImage = true;
}
