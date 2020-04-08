using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonRollGameLogic.Models
{
    public class Hero
    {
        public string Name { get; set; }
        public HeroSpecial Special { get; set; }
        public int XP { get; set; }
        public int Level { get; set; }
    }

    public class HeroSpecial
    {
        public string Name { get; set; }
        public SpecialEffect Effekt { get; set; }
        public SpecialAttack Attack { get; set; }
    }

    public class SpecialAttack
    {
    }
}