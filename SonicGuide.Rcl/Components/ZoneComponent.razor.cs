namespace SonicGuide.Rcl.Components;

public partial class ZoneComponent
{
    [Parameter, EditorRequired] public Zone? Zone { get; set; }
}
