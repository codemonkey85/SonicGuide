namespace SonicGuide.Rcl.Components;

public partial class BossComponent
{
    [Parameter, EditorRequired] public Boss? Boss { get; set; }

    private async Task SpeakBossName()
    {
        if (Boss?.name is null)
        {
            return;
        }
        await JsInterop.SpeakTextAsync(Boss.name);
    }
}
