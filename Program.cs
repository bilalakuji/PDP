using System;

namespace programmingproblems
{
    class NameBadgeGenerator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, please input your name:");
            string name = Console.ReadLine();
            Console.WriteLine($"Hi {name}!");

            Console.WriteLine("Please now enter your job occupation:");
            string job = Console.ReadLine();

            Console.WriteLine("Next,enter your phone number");
            double number = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please see your name badge below");
            Console.WriteLine($"\nName: {name}\nOccupation: {job}\nContact Number: {number}");

    }
}