﻿using ARPGEnemySystem.Common.Configs;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace ARPGEnemySystem.Common.Systems
{
    public class WorldManager : ModSystem
    {
        public static List<int> downedBossIDs = new List<int>();
        public static int downedBossNum = 0;
        public static int levelCap = 0;

        public override void ClearWorld()
        {
            downedBossIDs = new List<int>();
            downedBossNum = 0;
            levelCap = 0;
        }

        public static void DownedBoss(NPC npc)
        {
            if (npc.boss)
            {
                // Means that this boss was already killed before
                if (downedBossIDs.Any(x => x == npc.type))
                {
                    return;
                }
                else
                {
                    downedBossNum++;
                    downedBossIDs.Add(npc.type);
                    levelCap += ModContent.GetInstance<Config>().LevelCapIncreasePerBossDowned;
                    Main.NewText("Killing this enemy has released its power upon the world", Color.DarkRed);
                }
            }
        }

        public override void SaveWorldData(TagCompound tag)
        {
            tag["downedBossIDs"] = downedBossIDs;
            tag["downedBossNum"] = downedBossNum;
        }

        public override void LoadWorldData(TagCompound tag)
        {
            if (tag.ContainsKey("downedBossIDs"))
                downedBossIDs = (List<int>)tag.GetList<int>("downedBossIDs");
            if (tag.ContainsKey("downedBossNum"))
                downedBossNum = tag.GetAsInt("downedBossNum");
            levelCap = 0 + downedBossIDs.Count * ModContent.GetInstance<Config>().LevelCapIncreasePerBossDowned;
        }

        public override void NetSend(BinaryWriter writer)
        {
            writer.Write(downedBossIDs.Count);
            foreach (var id in downedBossIDs)
            {
                writer.Write(id);
            }
        }

        public override void NetReceive(BinaryReader reader)
        {
            var idListCount = reader.ReadInt32();
            for (int i = 0; i < idListCount; i++)
            {
                downedBossIDs.Add(reader.ReadInt32());
            }
            levelCap = 0 + downedBossIDs.Count * ModContent.GetInstance<Config>().LevelCapIncreasePerBossDowned;
        }
    }
}
