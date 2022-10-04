namespace SonicGuide.Rcl.Components;

public partial class BossComponent
{
    [Parameter, EditorRequired] public Boss? Boss { get; set; }
}
