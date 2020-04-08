﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;

namespace DungeonRollGameLogic.Models
{
    public class Game
    {
        public int DragonDiceCount { get; set; } = 0;
        public List<Player> Players { get; set; }
        public List<Dice> DiceList { get; set; } = new List<Dice>();
        public List<Hero> HeroList { get; set; } = new List<Hero>();

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
            fillHeroes();
            fillDice();
        }

        private void addPlayer(string name, Hero chosenHero)
        {
        }

        public void fillDice()
        {
            DiceList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Dice>>(File.ReadAllText("Json/Dices.json", Encoding.UTF8));
        }

        public void fillHeroes()
        {
            HeroList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Hero>>(File.ReadAllText("Json/Heroes.json", Encoding.UTF8));
        }
    }

    internal class gameIntern
    {
    }
}