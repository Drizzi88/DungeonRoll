using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DungeonRollGameLogic.Models
{
    public class Game
    {
        public int DragonDiceCount { get; set; } = 0;
        public List<Player> Players { get; set; }

        public int setDragonDiceCount(int diceCount)
        {
            DragonDiceCount = diceCount;
            return DragonDiceCount;
        }

        public int AddDragonDiceCount()
        {
            DragonDiceCount++;
            return DragonDiceCount;
        }

        public int removeDragonDiceCount()
        {
            DragonDiceCount = 0;
            return DragonDiceCount;
        }

        public void initializeGame()
        {
        }

        private void addPlayer(string name, Hero chosenHero)
        {
        }

        public List<Hero> getAvailableHeroes()
        {
            List<Hero> HeroList = new List<Hero>();
            return HeroList;
        }
    }

    internal class gameIntern
    {
    }
}