using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;

namespace ARPGEnemySystem.Common.DrawEffects
{
    public class ModifierDrawEffect
    {

        internal static void DrawBurning(NPC npc)
        {
            Random rand = new Random();
            if (rand.Next(0, 100) < 40)
            {
                int dustType = 6;
                var dust = Dust.NewDustDirect(npc.position, npc.width, npc.height, dustType);

                dust.noGravity = true;
                dust.velocity.X += Main.rand.NextFloat(-0.02f, 0.02f);
                dust.velocity.Y += Main.rand.NextFloat(-0.02f, 0.02f);

                dust.scale *= 1f + Main.rand.NextFloat(-0.01f, 0.01f);
            }
        }
        internal static void DrawVenom(NPC npc)
        {
            Random rand = new Random();
            if (rand.Next(0, 100) < 40)
            {
                int dustType = 46;
                var dust = Dust.NewDustDirect(npc.position, npc.width, npc.height, dustType);

                dust.noGravity = true;
                dust.velocity.X += Main.rand.NextFloat(-0.02f, 0.02f);
                dust.velocity.Y += Main.rand.NextFloat(-0.02f, 0.02f);

                dust.scale *= 1f + Main.rand.NextFloat(-0.01f, 0.01f);
            }
        }
        internal static void DrawFrost(NPC npc)
        {
            Random rand = new Random();
            if (rand.Next(0, 100) < 40)
            {
                int dustType = 67;
                var dust = Dust.NewDustDirect(npc.position, npc.width, npc.height, dustType);

                dust.noGravity = true;
                dust.velocity.X += Main.rand.NextFloat(-0.02f, 0.02f);
                dust.velocity.Y += Main.rand.NextFloat(-0.02f, 0.02f);

                dust.scale *= 1f + Main.rand.NextFloat(-0.01f, 0.01f);
            }
        }
        internal static void DrawSoulDrinker(NPC npc)
        {
            Random rand = new Random();
            if (rand.Next(0, 100) < 40)
            {
                int dustType = 45;
                var dust = Dust.NewDustDirect(npc.position, npc.width, npc.height, dustType);

                dust.noGravity = true;
                dust.velocity.X += Main.rand.NextFloat(-0.02f, 0.02f);
                dust.velocity.Y += Main.rand.NextFloat(-0.02f, 0.02f);

                dust.scale *= 1f + Main.rand.NextFloat(-0.01f, 0.01f);
            }
        }

    }
}
