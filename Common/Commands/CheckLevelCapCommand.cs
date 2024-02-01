using ARPGEnemySystem.Common.Systems;
using log4net.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace ARPGEnemySystem.Common.Commands
{
    public class CheckLevelCapCommand : ModCommand
    {
        public override CommandType Type
            => CommandType.Chat;
        public override string Command
            => "checklevelcap";
        public override string Description
            => "Check current world level cap";

        public override void Action(CommandCaller caller, string input, string[] args)
        {
            Main.NewText(WorldManager.levelCap);
        }
    }
}
