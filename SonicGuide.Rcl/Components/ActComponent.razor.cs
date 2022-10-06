namespace SonicGuide.Rcl.Components;

public partial class ActComponent
{
    [Parameter, EditorRequired] public Game? Game { get; set; }

    [Parameter, EditorRequired] public Zone? Zone { get; set; }

    [Parameter, EditorRequired] public Act? Act { get; set; }

    private async Task SpeakActName()
    {
        if (Act?.name is null)
        {
            return;
        }
        await JsInterop.SpeakTextAsync(Act.name);
    }

    private bool hideImage = false;

    private void OnImgError() => hideImage = true;
}
