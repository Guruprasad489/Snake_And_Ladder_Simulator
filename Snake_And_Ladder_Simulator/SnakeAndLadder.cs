using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_And_Ladder_Simulator
{
    internal class SnakeAndLadder
    {
        public const int NO_PLAY = 0, LADDER = 1, SNAKE = 2;
        public int player_Position = 0, DiceRoll;
        public void PlaySnakeAndLadder()
        {
            Console.WriteLine("Game starts now...");
            Console.WriteLine("Starting position of player is: " + player_Position);
            Random random = new Random();
            DiceRoll= random.Next(1,7);
            Console.WriteLine("Player gets Dice Number: " + DiceRoll);
            
            switch(random.Next(0, 3))
            {
                case NO_PLAY:
                    Console.WriteLine("No Play");
                    break;
                    
                case LADDER:
                    player_Position += DiceRoll;
                    Console.WriteLine("Ladder: " + player_Position);
                    break;
                case SNAKE:
                    player_Position -= DiceRoll;
                    Console.WriteLine("Snake: " + player_Position);
                    break;
            }

        }

    }

}
