namespace SonicGuide.Rcl.Components;

public partial class GameComponent
{
    [Parameter, EditorRequired] public Game? Game { get; set; }
}
