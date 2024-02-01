using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader.Config;

namespace ARPGEnemySystem.Common.Configs
{
    public class Config : ModConfig
    {

        public override ConfigScope Mode => ConfigScope.ServerSide;

        [DefaultValue(10)]
        public int LevelCapIncreasePerBossDowned;

        [Header("NormalEnemy")]

        [DefaultValue(true)]
        public bool ModifierAllowed;

        [Range(0.000f, 0.1f)]
        [Increment(0.001f)]
        [DrawTicks]
        [DefaultValue(0.004f)]
        public float NormalEnemyHPIncreasePerLevel;

        [Range(0.000f, 0.2f)]
        [Increment(0.002f)]
        [DrawTicks]
        [DefaultValue(0.02f)]
        public float NormalEnemyDefenseIncreasePerLevel;

        [Range(0.000f, 0.1f)]
        [Increment(0.001f)]
        [DrawTicks]
        [DefaultValue(0.004f)]
        public float NormalEnemyDamageIncreasePerLevel;

        [Header("Boss")]

        [Range(0.000f, 0.1f)]
        [Increment(0.001f)]
        [DrawTicks]
        [DefaultValue(0.006f)]
        public float BossHPIncreasePerLevel;

        [Range(0.000f, 0.2f)]
        [Increment(0.002f)]
        [DrawTicks]
        [DefaultValue(0.02f)]
        public float BossDefenseIncreasePerLevel;

        [Range(0.000f, 0.1f)]
        [Increment(0.001f)]
        [DrawTicks]
        [DefaultValue(0.006f)]
        public float BossDamageIncreasePerLevel;
    }

    public class ConfigClient : ModConfig
    {

        public override ConfigScope Mode => ConfigScope.ClientSide;

        [DefaultValue(true)]
        public bool EnableEnemyStatPanel;
    }
}
