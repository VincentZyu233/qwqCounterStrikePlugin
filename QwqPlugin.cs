using CounterStrikeSharp.API.Core;
using CounterStrikeSharp.API.Modules.Utils;
using Microsoft.Extensions.Logging;

namespace qwqCounterStrikePlugin;

public class QwqPlugin : BasePlugin
{
    public override string ModuleName => "qwq CounterStrike Plugin";
    public override string ModuleVersion => "0.0.1";

    public override void Load(bool hotReload)
    {
        RegisterEventHandler<EventPlayerChat>((@event, _) =>
        {
            var player = @event.Userid;
            if (player == null || !player.IsValid) return HookResult.Continue;

            if (@event.Text.Trim() == "qwq")
                player.PrintToChat($" {ChatColors.Green}qwq!");

            return HookResult.Continue;
        });
    }
}
