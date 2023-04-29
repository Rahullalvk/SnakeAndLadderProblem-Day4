using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace SnakeAndLadder
{
    internal class SnakeAndLadder
    {
        public static void DisplaySnakeAndLadder()
        {
            int playerPosition = 0;
            Random random = new Random();
            int diceRolls = 0;
            while (playerPosition < 100)
            {
                int roll = random.Next(1, 7);
                Console.WriteLine($"You rolled a {roll}.");
                diceRolls++;

                int option = random.Next(0, 3);

                switch (option)
                {
                    case 0:
                        Console.WriteLine("No Play. You stay in the same position.");
                        break;
                    case 1:
                        int ladderSteps = random.Next(1, 7);
                        Console.WriteLine($"You landed on a ladder! Move up {ladderSteps} positions.");
                        playerPosition += ladderSteps;
                        break;
                    case 2:
                        int snakeSteps = random.Next(1, 7);
                        Console.WriteLine($"You landed on a snake! Move back {snakeSteps} positions.");
                        playerPosition -= snakeSteps;
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
                if (playerPosition < 0)
                {
                    playerPosition = 0;
                }
                else if (playerPosition > 100)
                {
                    playerPosition = 100;
                }

                if (playerPosition == 100)
                {
                    Console.WriteLine("Congratulations! You reached the finish.");
                    break;
                }

                Console.WriteLine($"You are now at position {playerPosition}.");
            }
            Console.WriteLine($"Congratulations! You reached the finish in {diceRolls} rolls.");
            Console.ReadKey();

           
        }
    }
}














        
