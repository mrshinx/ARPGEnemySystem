using ARPGEnemySystem.Common.Database;
using ARPGEnemySystem.Common.GlobalNPCs;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.Chat;
using Terraria.ID;

namespace ARPGEnemySystem.Common
{
    public class Utils
    {
        internal static List<int> CreateExcludeList(List<EnemyModifier> modifierList)
        {
            var excludeModifierListEnum = modifierList.Select(o => o.modifierType).ToList();
            List<int> excludeListInt = new List<int>();

            foreach (var item in excludeModifierListEnum)
            {
                excludeListInt.Add((int)item);
            }

            return excludeListInt;
        }
        internal static int GetAmountOfEnemyModifier()
        {
            Random random = new Random();
            return random.Next(0, 3);
        }
        internal static int GetTier()
        {
            Random random = new Random();
            int maximumTier = 8;
            int minimumTier = 10;
            if (NPC.downedSlimeKing) maximumTier -= 1;
            if (NPC.downedBoss2) minimumTier -= 1;
            if (NPC.downedBoss3) maximumTier -= 1;
            if (Main.hardMode) maximumTier -= 1;
            if (NPC.downedQueenSlime) minimumTier -= 1;
            if (NPC.downedMechBossAny) maximumTier -= 1;
            if (NPC.downedGolemBoss) minimumTier -= 1;
            if (NPC.downedPlantBoss) { maximumTier -= 1; }
            if (NPC.downedFishron) { minimumTier -= 1; }
            if (NPC.downedEmpressOfLight) { maximumTier -= 1; minimumTier -= 1; }
            if (NPC.downedAncientCultist) { maximumTier -= 1; }
            if (NPC.downedMoonlord) { maximumTier -= 1; minimumTier -= 1; }

            return random.Next(maximumTier, minimumTier);
        }
        internal static bool IsDummy(NPC npc)
        {
            var nameSpan = NPCID.Search.GetName(npc.type).AsSpan();
            var index = nameSpan.IndexOf('/');
            if (index != -1)
                nameSpan = nameSpan[index..];
            return nameSpan.ToString().ToLowerInvariant().Contains("dummy");
        }
    }
}
