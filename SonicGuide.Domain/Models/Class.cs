namespace SonicGuide.Domain.Models;

public class GameData
{
    public Game[]? games { get; set; }
}

public class Game
{
    public string? name { get; set; }

    public int? order { get; set; }

    public Zone[]? zones { get; set; }
}

public class Zone
{
    public string? name { get; set; }

    public int? order { get; set; }

    public Act[]? acts { get; set; }
}

public class Act
{
    public string? name { get; set; }

    public int? order { get; set; }

    public Boss[]? bosses { get; set; }
}

public class Boss
{
    public string? name { get; set; }

    public int? order { get; set; }
}
