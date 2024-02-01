using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria;
using Terraria.UI;
using Microsoft.Xna.Framework;
using Terraria.GameContent.UI.Elements;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Terraria.GameInput;
using Terraria.GameContent.Events;
using ARPGEnemySystem.Common.GlobalNPCs;

namespace ARPGEnemySystem.Common.UI
{
    internal class NPCUI : UIState
    {
        //public NPCTooltip npcTooltip;

        public override void OnInitialize()
        {

        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            RemoveAllChildren();
            var npcTooltip = new UITextPanel<string>("");
            npcTooltip.DrawPanel=false;
            Append(npcTooltip);

            // These are needed to make sure that the mouse position works correctly for every zoom level
            PlayerInput.SetZoom_Unscaled();
            PlayerInput.SetZoom_MouseInWorld();

            // Get mouse "hitbox"
            Rectangle mouseRectangle = new Rectangle((int)(Main.mouseX + Main.screenPosition.X), (int)(Main.mouseY + Main.screenPosition.Y), 1, 1);

            // This is needed to make sure that the mouse position works correctly for every UI zoom level
            PlayerInput.SetZoom_UI();

            // Loop through (hopefully) every NPC on screen and check
            for (int i = 0; i < 200; i++)
            {
                var npc = Main.npc[i];
                if (!npc.active) continue;

                // Get NPC "hitbox"
                Rectangle npcPos = new Rectangle((int)npc.Bottom.X - npc.frame.Width / 2, (int)npc.Bottom.Y - npc.frame.Height, npc.frame.Width, npc.frame.Height);

                if (mouseRectangle.Intersects(npcPos))
                {
                    NPCManager modNpc;
                    BossManager bossNpc;
                    if (npc.TryGetGlobalNPC<NPCManager>(out modNpc))
                    {
                        string tooltipText = npc.GivenOrTypeName +
                                            $"\nLevel: {modNpc.level} " +
                                            $"\nRarity: {modNpc.rarity.rarity} " +
                                            $"\nModifier: {String.Join(", ", modNpc.modifierList.Select(o => o.modifierType).ToList())}" +
                                            $"\nDefense: {npc.defense}";
                        npcTooltip.SetText(tooltipText);
                        npcTooltip.Width.Set(npcTooltip.TextSize.X, 0);
                        npcTooltip.Height.Set(130, 0);
                        npcTooltip.Left.Set(Main.screenWidth / 2 - npcTooltip.Width.Pixels/2, 0);
                        npcTooltip.Top.Set(Main.screenHeight / 10, 0);
                        npcTooltip.Recalculate();
                        npcTooltip.DrawPanel = true;
                    }
                    if (npc.TryGetGlobalNPC<BossManager>(out bossNpc))
                    {
                        string tooltipText = npc.GivenOrTypeName +
                                            $"\nLevel: {bossNpc.level} " +
                                            $"\nDefense: {npc.defense}";
                        npcTooltip.SetText(tooltipText);
                        npcTooltip.Width.Set(npcTooltip.TextSize.X, 0);
                        npcTooltip.Height.Set(80, 0);
                        npcTooltip.Left.Set(Main.screenWidth / 2 - npcTooltip.Width.Pixels / 2, 0);
                        npcTooltip.Top.Set(Main.screenHeight / 10, 0);
                        npcTooltip.Recalculate();
                        npcTooltip.DrawPanel = true;
                    }

                }
            }
        }
    }
}
