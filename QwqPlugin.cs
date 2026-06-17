using CounterStrikeSharp.API;
using CounterStrikeSharp.API.Core;
using CounterStrikeSharp.API.Modules.Events;
using CounterStrikeSharp.API.Modules.Utils;
using Microsoft.Extensions.Logging;

namespace qwqCounterStrikePlugin;

public class QwqPlugin : BasePlugin
{
    public override string ModuleName => "qwq CounterStrike Plugin";
    public override string ModuleVersion => "0.1.2";

    public override void Load(bool hotReload)
    {
        Logger.LogInformation("Load() called, registering EventPlayerChat...");

        RegisterEventHandler<EventPlayerChat>((@event, info) =>
        {
            Logger.LogInformation("EventPlayerChat fired!");
            Logger.LogInformation($"  userid={@event.Userid}");
            Logger.LogInformation($"  text='{@event.Text}'");
            Logger.LogInformation($"  teamonly={@event.Teamonly}");

            var player = Utilities.GetPlayerFromIndex(@event.Userid);
            if (player == null)
            {
                Logger.LogInformation("  player is NULL");
                return HookResult.Continue;
            }
            Logger.LogInformation($"  player.IsValid={player.IsValid}");
            Logger.LogInformation($"  player.PlayerName='{player.PlayerName}'");
            Logger.LogInformation($"  player.SteamID={player.SteamID}");

            var trimmed = @event.Text.Trim().ToLower();
            Logger.LogInformation($"  trimmed text='{trimmed}'");
            Logger.LogInformation($"  matches qwq? {trimmed == "qwq"}");

            if (trimmed == "qwq")
            {
                Logger.LogInformation("  MATCH! Attempting PrintToChat...");
                player.PrintToChat($" {ChatColors.Green}qwq!");
                Logger.LogInformation("  PrintToChat completed.");
            }

            return HookResult.Continue;
        });

        Logger.LogInformation("EventPlayerChat registered.");
    }
}
