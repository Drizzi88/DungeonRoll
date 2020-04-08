using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonRollGameLogic.Models
{
    public class Loot
    {
        public string Name { get; set; }
        public int XPValue { get; set; }
        public string Description { get; set; }
        public bool isReplacement { get; set; }
        public Dice replacementDice { get; set; }
        public SpecialEffect SpecialEffect { get; set; }
    }
}