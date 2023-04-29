using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using System.Reflection;

namespace SnakeAndLadder
{
    internal class SnakeAndLadder
    {
        public static void DisplaySnakeAndLadder()
        {
            int player1Position = 0;
            int player2Position = 0;
            Random random = new Random();
            int diceRolls = 0;
            int currentPlayer = 1;

            while (player1Position < 100 && player2Position < 100)
            {
                int roll = random.Next(1, 7);
                Console.WriteLine($"Player {currentPlayer} rolled a {roll}.");
                diceRolls++;

                int option = random.Next(0, 3); // 0 = No Play, 1 = Ladder, 2 = Snake

                switch (option)
                {
                    case 0:
                        Console.WriteLine("No Play. Player stays in the same position.");
                        break;
                    case 1:
                        int ladderSteps = random.Next(1, 7);
                        Console.WriteLine($"Player landed on a ladder! Move up {ladderSteps} positions.");
                        if (currentPlayer == 1)
                        {
                            player1Position += ladderSteps;
                        }
                        else
                        {
                            player2Position += ladderSteps;
                        }
                        break;
                    case 2:
                        int snakeSteps = random.Next(1, 7);
                        Console.WriteLine($"Player landed on a snake! Move back {snakeSteps} positions.");
                        if (currentPlayer == 1)
                        {
                            player1Position -= snakeSteps;
                        }
                        else
                        {
                            player2Position -= snakeSteps;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }

                if (player1Position < 0)
                {
                    player1Position = 0;
                }
                else if (player1Position > 100)
                {
                    player1Position = 100;
                }

                if (player2Position < 0)
                {
                    player2Position = 0;
                }
                else if (player2Position > 100)
                {
                    player2Position = 100;
                }

                Console.WriteLine($"Player 1 is now at position {player1Position}.");
                Console.WriteLine($"Player 2 is now at position {player2Position}.");

                if (option != 1)
                {
                    currentPlayer = (currentPlayer == 1) ? 2 : 1;
                }
            }

            if (player1Position >= 100)
            {
                Console.WriteLine($"Player 1 won the game in {diceRolls} rolls!");
            }
            else
            {
                Console.WriteLine($"Player 2 won the game in {diceRolls} rolls!");
            }

            Console.ReadKey();
        }
    }
}


    

























        
