using CounterStrikeSharp.API;
using CounterStrikeSharp.API.Core;
using CounterStrikeSharp.API.Modules.Events;
using CounterStrikeSharp.API.Modules.Utils;

namespace qwqCounterStrikePlugin;

public class QwqPlugin : BasePlugin
{
    public override string ModuleName => "qwq CounterStrike Plugin";
    public override string ModuleVersion => "0.1.1";

    public override void Load(bool hotReload)
    {
        RegisterEventHandler<EventPlayerChat>((@event, _) =>
        {
            var player = Utilities.GetPlayerFromIndex(@event.Userid);
            if (player == null || !player.IsValid) return HookResult.Continue;

            if (@event.Text.Trim().ToLower() == "qwq")
                player.PrintToChat($" {ChatColors.Green}qwq!");

            return HookResult.Continue;
        });
    }
}
