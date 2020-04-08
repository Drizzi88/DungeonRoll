using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace DungeonRollGameLogic.Models
{
    public class Dice
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public List<Dice> StrongAgainst { get; set; } = new List<Dice>();
        public List<Dice> WeakAgainst { get; set; } = new List<Dice>();
        public string ImagePath { get; set; }

        public void generateBaseDice()
        {
            List<Dice> dices = new List<Dice>();
            Dice dice = new Dice();
            dice.Name = "Wizard";
            dice.Type = "Wizard";
            dice.StrongAgainst.Add(new Dice("Slime"));
            dice.WeakAgainst.Add(new Dice("Dice A"));
            dice.ImagePath = "C:/a.img";
            dices.Add(dice);
            File.WriteAllText("Dice.json", JsonConvert.SerializeObject(dices), Encoding.UTF8);
        }

        public Dice()
        {
        }

        public Dice(string name)
        {
            Name = name;
        }
    }
}