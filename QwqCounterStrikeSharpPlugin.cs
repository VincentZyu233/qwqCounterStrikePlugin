using CounterStrikeSharp.API;
using CounterStrikeSharp.API.Core;
using CounterStrikeSharp.API.Modules.Events;
using CounterStrikeSharp.API.Modules.Utils;
using Microsoft.Extensions.Logging;

namespace qwqCounterStrikeSharpPlugin;

public class QwqCounterStrikeSharpPlugin : BasePlugin
{
    public override string ModuleName => "qwq CounterStrikeSharp Plugin";
    public override string ModuleVersion => "0.1.6";

    public override void Load(bool hotReload)
    {
        RegisterEventHandler<EventPlayerChat>((@event, _) =>
        {
            Logger.LogInformation($"EventPlayerChat fired: userid={@event.Userid}, text='{@event.Text}', teamonly={@event.Teamonly}");

            var player = Utilities.GetPlayerFromUserid(@event.Userid);
            if (player == null)
            {
                Logger.LogInformation("player is NULL");
                return HookResult.Continue;
            }
            if (!player.IsValid)
            {
                Logger.LogInformation("player is invalid");
                return HookResult.Continue;
            }

            Logger.LogInformation($"player={player.PlayerName}, steamid={player.SteamID}");

            if (@event.Text.Trim().ToLower() == "qwq")
                player.PrintToChat($" {ChatColors.Green}qwq!");

            return HookResult.Continue;
        });
    }
}
