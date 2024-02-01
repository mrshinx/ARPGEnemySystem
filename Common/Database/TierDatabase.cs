using ARPGEnemySystem.Common.GlobalNPCs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARPGEnemySystem.Common.Database
{
    public struct Tier
    {
        public int minValue;
        public int maxValue;
        public Tier(int min, int max)
        {
            minValue = min; maxValue = max;
        }
    }
    public static class TierDatabase
    {
        public static Dictionary<Enum, List<Tier>> modifierTierDatabase = new Dictionary<Enum, List<Tier>>()
        {
            // Prefix
                // Weapon
            {ModifierType.Colossal, new List<Tier>
            {
                new Tier(56,60),
                new Tier(51,55),
                new Tier(46,50),
                new Tier(41,45),
                new Tier(36,40),
                new Tier(31,35),
                new Tier(26,30),
                new Tier(21,25),
                new Tier(16,20),
                new Tier(10,15)
            } },
            {ModifierType.Tiny, new List<Tier>
            {
                new Tier(56,60),
                new Tier(51,55),
                new Tier(46,50),
                new Tier(41,45),
                new Tier(36,40),
                new Tier(31,35),
                new Tier(26,30),
                new Tier(21,25),
                new Tier(16,20),
                new Tier(10,15)
            } },
            {ModifierType.Poisonous, new List<Tier>
            {
                new Tier(56,60),
                new Tier(51,55),
                new Tier(46,50),
                new Tier(41,45),
                new Tier(36,40),
                new Tier(31,35),
                new Tier(26,30),
                new Tier(21,25),
                new Tier(16,20),
                new Tier(10,15)
            } },
            {ModifierType.Burning, new List<Tier>
            {
                new Tier(56,60),
                new Tier(51,55),
                new Tier(46,50),
                new Tier(41,45),
                new Tier(36,40),
                new Tier(31,35),
                new Tier(26,30),
                new Tier(21,25),
                new Tier(16,20),
                new Tier(10,15)
            } },
            {ModifierType.Strong, new List<Tier>
            {
                new Tier(56,60),
                new Tier(51,55),
                new Tier(46,50),
                new Tier(41,45),
                new Tier(36,40),
                new Tier(31,35),
                new Tier(26,30),
                new Tier(21,25),
                new Tier(16,20),
                new Tier(10,15)
            } },
            {ModifierType.Durable, new List<Tier>
            {
                new Tier(56,60),
                new Tier(51,55),
                new Tier(46,50),
                new Tier(41,45),
                new Tier(36,40),
                new Tier(31,35),
                new Tier(26,30),
                new Tier(21,25),
                new Tier(16,20),
                new Tier(10,15)
            } },
            {ModifierType.Quick, new List<Tier>
            {
                new Tier(101,110),
                new Tier(91,100),
                new Tier(81,90),
                new Tier(71,80),
                new Tier(61,70),
                new Tier(51,60),
                new Tier(41,50),
                new Tier(31,40),
                new Tier(21,30),
                new Tier(10,20)
            } },
            {ModifierType.Frosty, new List<Tier>
            {
                new Tier(56,60),
                new Tier(51,55),
                new Tier(46,50),
                new Tier(41,45),
                new Tier(36,40),
                new Tier(31,35),
                new Tier(26,30),
                new Tier(21,25),
                new Tier(16,20),
                new Tier(10,15)
            } },
            {ModifierType.SoulDrinker, new List<Tier>
            {
                new Tier(56,60),
                new Tier(51,55),
                new Tier(46,50),
                new Tier(41,45),
                new Tier(36,40),
                new Tier(31,35),
                new Tier(26,30),
                new Tier(21,25),
                new Tier(16,20),
                new Tier(10,15)
            } },
            {ModifierType.Destroyer, new List<Tier>
            {
                new Tier(28,30),
                new Tier(25,27),
                new Tier(22,24),
                new Tier(19,21),
                new Tier(16,18),
                new Tier(13,15),
                new Tier(10,12),
                new Tier(07,09),
                new Tier(04,06),
                new Tier(01,03)
            } },
        };
    }
}
