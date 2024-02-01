using ARPGEnemySystem.Common.Systems;
using log4net.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;

namespace ARPGEnemySystem.Common.Commands
{
    public class ResetWorldCommand : ModCommand
    {
        public override CommandType Type
            => CommandType.Chat;
        public override string Command
            => "resetworld";
        public override string Description
            => "Reset world level cap and boss progression";

        public override void Action(CommandCaller caller, string input, string[] args)
        {
            WorldManager.downedBossIDs = new List<int>();
            WorldManager.downedBossNum = 0;
            WorldManager.levelCap = 0;
        }
    }
}
