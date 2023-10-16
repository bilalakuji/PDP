using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Spectre.Console;
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
=======
    class NameBadgeGenerator
    {
        static void Main(string[] args)
        {

            AnsiConsole.Write(
                new FigletText("Hello")
                    .Color(Color.Blue));

            AnsiConsole.Markup("[underline red]Hello[/], please input your name: ");
            string name = Console.ReadLine();
            AnsiConsole.Markup($"Hi [underline blue]{name}[/]! ");

            Console.WriteLine("Please now enter your job occupation:");
            string job = Console.ReadLine();
            AnsiConsole.Write(
                new FigletText("Wow!")
                    .Color(Color.Yellow));

            Console.WriteLine("Next,enter your phone number");
            decimal number = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Please see your name badge below");
                Console.WriteLine($"┌───────────────────────────────────────────────────────────────────-─┐");
                Console.WriteLine($"│ Name:           {name}\n  Occupation:     {job}\n  Contact Number: {number}");
                Console.WriteLine($"└─────────────────────────────────────────────────────────────────────┘");
        }
    }
    }
