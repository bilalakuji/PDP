using System;

namespace PDP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new();
            int playerScore = 0;
            int cpuScore = 0;
            bool userExit = true;

            Console.WriteLine("Welcome to rock paper scissors!");

            while (userExit)
            {
                Console.WriteLine(); 
                Console.WriteLine("Player score: " + playerScore + " \nCPU score: " + cpuScore);

                Console.Write("Would you like to end(y/n)?\n");
                string userEnd = Console.ReadLine();
                
                if (userEnd == "y")
                {
                    Console.WriteLine("\nGoodbye!");
                    Environment.Exit(0);
                }
                else if (userEnd == "n")
                {
                    Console.WriteLine("\nOk, we proceed!");
                }
                else
                {
                    Console.WriteLine("\nInvalid Entry");
                    continue;
                }

                Console.WriteLine("Please enter either 'rock', 'paper' or 'scissors'.\n");
                string playerChoice = Console.ReadLine();

                int cpuChoice = random.Next(0, 3);

                if (cpuChoice == 0) 
                {
                    Console.WriteLine("I choose rock.");

                    switch (playerChoice)
                    {
                        case "rock":
                            Console.WriteLine("Draw.");
                            break;
                        case "paper":
                            Console.WriteLine("You win.");
                            playerScore++;
                            break;
                        case "scissors":
                            Console.WriteLine("I win!");
                            cpuScore++;
                            break;
                        default:
                            Console.WriteLine("Invalid Entry!");
                            continue;
                    }
                }

                else if (cpuChoice == 1) 
                {
                    Console.WriteLine("I choose paper.");

                    switch (playerChoice)
                    {
                        case "rock":
                            Console.WriteLine("I win!");
                            cpuScore++;
                            break;
                        case "paper":
                            Console.WriteLine("Draw.");
                            break;
                        case "scissors":
                            Console.WriteLine("You win!");
                            playerScore++;
                            break;
                        default:
                            Console.WriteLine("Invalid Entry!");
                            continue;
                    }
                }

                else if (cpuChoice == 2) 
                {
                    Console.WriteLine("I choose scissors.");

                    switch (playerChoice)
                    {
                        case "rock":
                            Console.WriteLine("You win.");
                            playerScore++;
                            break;
                        case "paper":
                            Console.WriteLine("I win!");
                            cpuScore++;
                            break;
                        case "scissors":
                            Console.WriteLine("Draw!");
                            break;
                        default:
                            Console.WriteLine("Invalid Entry.");
                            continue;
                    }
                }
            }
        }
    }
}
