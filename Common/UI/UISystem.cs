using ARPGEnemySystem.Common.Configs;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.UI;

namespace ARPGEnemySystem.Common.UI
{
    internal class UISystem : ModSystem
    {
        internal NPCUI npcUI;
        private UserInterface _npcUI;
        public override void Load()
        {
            npcUI = new NPCUI();
            npcUI.Activate();
            _npcUI = new UserInterface();
            _npcUI.SetState(npcUI);
        }
        public override void UpdateUI(GameTime gameTime)
        {
            _npcUI?.Update(gameTime);
            if (ModContent.GetInstance<ConfigClient>().EnableEnemyStatPanel)
                _npcUI.SetState(npcUI);
            else
                _npcUI.SetState(null);
        }
        public override void ModifyInterfaceLayers(List<GameInterfaceLayer> layers)
        {
            int mouseTextIndex = layers.FindIndex(layer => layer.Name.Equals("Vanilla: Mouse Text"));
            if (mouseTextIndex != -1)
            {
                layers.Insert(mouseTextIndex, new LegacyGameInterfaceLayer(
                    "ARPG Enemy System: NPC UI",
                    delegate
                    {
                        _npcUI.Draw(Main.spriteBatch, new GameTime());
                        return true;
                    },
                    InterfaceScaleType.UI)
                );
            }
        }
    }
}
