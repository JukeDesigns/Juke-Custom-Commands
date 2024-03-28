using CounterStrikeSharp.API.Core;

namespace CustomCommands;

public class Commands : BasePlugin
{
    private readonly ILogger<Commands> _logger;

    public Commands(ILogger<Commands> logger)
    {
        _logger = logger;
    }

    public void CustomCommandsLog()
    {
        _logger.LogInformation("Juke's Custom Commands Loading...")
    }
}

public class CustomCommandsServiceCollection : IPluginServiceCollection<Juke-Custom-Command>
{
    public void ConfigureServices(IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<Commands>();
    }
}

[ConsoleCommand("discord", "Discord Link")]
public void OnDiscordCommand(CCSPlayerController? player, CommandInfo command)
{
    if (player = null) {
        Console.WriteLine("[blue]Join our Discord:[white] https://discord.gg/2cnMAqH548");
        return;
    }

    Console.WriteLine("Join our Discord: https://discord.gg/2cnMAqH548")
}