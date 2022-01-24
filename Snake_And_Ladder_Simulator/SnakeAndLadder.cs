using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_And_Ladder_Simulator
{
    internal class SnakeAndLadder
    {
        public int start_Position = 0, DiceRoll;
        public void RollTheDice()
        {
            Console.WriteLine("Game starts now...");
            Console.WriteLine("Starting position of player is: " + start_Position);
            Random random = new Random();
            DiceRoll= random.Next(1,7);
            Console.WriteLine("Player gets Dice Number: " + DiceRoll);
        }

    }

}
