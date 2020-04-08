using System;
using DungeonRollGameLogic;

namespace DungeonRollConsole
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DungeonRollGameLogic.Models.Dice dice = new DungeonRollGameLogic.Models.Dice();
            dice.generateBaseDice();
        }
    }
}