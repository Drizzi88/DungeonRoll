using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonRollGameLogic.Models
{
    public class Player
    {
        public string Name { get; set; }
        public List<Dice> Dice { get; set; }
        public Hero ChosenHero { get; set; }
    }
}