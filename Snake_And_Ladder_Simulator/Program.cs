﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_And_Ladder_Simulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Simulator program \n");
            SnakeAndLadder player = new SnakeAndLadder();
            player.RollTheDice();
            Console.ReadLine();
        }
    }
}
