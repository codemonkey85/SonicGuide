namespace SonicGuide.Rcl.Components;

public partial class ActComponent
{
    [Parameter, EditorRequired] public Act? Act { get; set; }

    private async Task SpeakActName()
    {
        if (Act?.name is null)
        {
            return;
        }
        await JsInterop.SpeakTextAsync(Act.name);
    }
}
