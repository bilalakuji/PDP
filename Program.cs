using System;

namespace programmingproblems
{
    class program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int playerScore = 0;
            int cpuScore = 0;

            Console.WriteLine("Welcome to rock paper scissors!");

            while (playerScore != 3 && cpuScore != 3)
            {
                Console.WriteLine(); 
                Console.WriteLine("Player score: " + playerScore + " \nCPU score: " + cpuScore);
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
                        default:
                            Console.WriteLine("I win, you suck!");
                            cpuScore++;
                            break;
                    }
                }
                else if (cpuChoice == 1) 
                {
                    Console.WriteLine("I choose paper.");

                    switch (playerChoice)
                    {
                        case "rock":
                            Console.WriteLine("I win, you suck!");
                            cpuScore++;
                            break;
                        case "paper":
                            Console.WriteLine("Draw.");
                            break;
                        default:
                            Console.WriteLine("You win.");
                            playerScore++;
                            break;
                    }

                }
                else 
                {
                    Console.WriteLine("I choose scissors.");

                    switch (playerChoice)
                    {
                        case "rock":
                            Console.WriteLine("You win.");
                            playerScore++;
                            break;
                        case "paper":
                            Console.WriteLine("I win, you suck!");
                            cpuScore++;
                            break;
                        default:
                            Console.WriteLine("Draw.");
                            break;
                    }
                }

            }
            if (playerScore == 3)
            {
                Console.WriteLine("\nCongratulations, you won.");
            }
            else
            {
                Console.WriteLine("\nYou lost!");
            }
        }
    }
    }
