using System;

namespace RockPaperScissors
{
    class Program
    {
        public static void Main()
        {
            String inputPlayer, inputCpu;
            int randomInt = 0;
            int scoreCpu = 0;
            int scorePlayer = 0;
            bool playerAgain = true;
            int attemptsPlayer = 0;

            while (playerAgain)
            {
                Console.WriteLine("Choose between Rock, Paper, Scissor");
                inputPlayer = Console.ReadLine().ToUpper();

                // Print the inputPlayer to check if it's correctly converted to uppercase
                Console.WriteLine($"You chose: {inputPlayer}");

                // Check if the input is valid before continuing
                if (inputPlayer != "ROCK" && inputPlayer != "PAPER" && inputPlayer != "SCISSOR")
                {
                    Console.WriteLine("Invalid choice, please choose Rock, Paper, or Scissors.");
                    continue; // Skip the rest of the loop and ask for input again
                }

                // CPU Generate choose random (Fixed random range to 1-3)
                Random random = new Random();
                randomInt = random.Next(1, 4);  // Random between 1 and 3 to include "ROCK", "PAPER", and "SCISSOR"

                // CPU choose option 
                switch (randomInt)
                {
                    case 1:
                        inputCpu = "ROCK";
                        Console.WriteLine($"Computer chose {inputCpu}");
                        if (inputPlayer == "ROCK")
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        else if (inputPlayer == "PAPER")
                        {
                            Console.WriteLine("Player Wins");
                            scorePlayer++;
                        }
                        else if (inputPlayer == "SCISSOR")
                        {
                            Console.WriteLine("Player Loses");
                            scoreCpu++;
                        }
                        break;

                    case 2:
                        inputCpu = "PAPER";
                        Console.WriteLine($"Computer chose {inputCpu}");
                        if (inputPlayer == "PAPER")
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        else if (inputPlayer == "ROCK")
                        {
                            Console.WriteLine("Player Loses");
                            scoreCpu++;
                        }
                        else if (inputPlayer == "SCISSOR")
                        {
                            Console.WriteLine("Player Wins");
                            scorePlayer++;
                        }
                        break;

                    case 3:
                        inputCpu = "SCISSOR";
                        Console.WriteLine($"Computer chose {inputCpu}");
                        if (inputPlayer == "SCISSOR")
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        else if (inputPlayer == "PAPER")
                        {
                            Console.WriteLine("Player Loses");
                            scoreCpu++;
                        }
                        else if (inputPlayer == "ROCK")
                        {
                            Console.WriteLine("Player Wins");
                            scorePlayer++;
                        }
                        break;

                    default:
                        Console.WriteLine("Error");
                        break;
                }

                // Number Attempts to play
                attemptsPlayer++;
                if (attemptsPlayer == 3)
                {
                    playerAgain = false;
                }
                Console.WriteLine($"Number attempt {attemptsPlayer}");
                Console.WriteLine();
            }

            if (scoreCpu > scorePlayer)
            {
                Console.WriteLine($"CPU Wins, number strikes CPU {scoreCpu}, Strikes Player {scorePlayer}");
            }
            else if (scoreCpu < scorePlayer)
            {
                Console.WriteLine($"Player Wins, number strikes Player {scorePlayer}, Strikes CPU {scoreCpu}");
            }
            else
            {
                Console.WriteLine($"Player and CPU draw, strikes CPU {scoreCpu}, strikes Player {scorePlayer}");
            }
        }
    }
}
