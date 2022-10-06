namespace SonicGuide.Rcl.Components;

public partial class ZoneComponent
{
    [Parameter, EditorRequired] public Zone? Zone { get; set; }

    private async Task SpeakZoneName()
    {
        if (Zone?.name is null)
        {
            return;
        }
        await JsInterop.SpeakTextAsync(Zone.name);
    }
}
