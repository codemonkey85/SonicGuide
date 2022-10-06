namespace SonicGuide.Rcl.Components;

public partial class ZoneComponent
{
    [Parameter, EditorRequired] public Game? Game { get; set; }

    [Parameter, EditorRequired] public Zone? Zone { get; set; }

    private async Task SpeakZoneName()
    {
        if (Zone?.name is null)
        {
            return;
        }
        await JsInterop.SpeakTextAsync(Zone.name);
    }

    private bool hideImage = false;

    private void OnImgError() => hideImage = true;
}
