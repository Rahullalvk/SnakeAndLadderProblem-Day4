using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class SnakeAndLadder
    {
        public static void DisplaySnakeAndLadder() 
        {
            int playerPosition = 0;
            Random random = new Random();
            int roll = random.Next(1, 7);
            Console.WriteLine($"You rolled a {roll}.");

            playerPosition += roll;

        }
    }
}
