using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Spectre.Console;
namespace programmingproblems
{
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