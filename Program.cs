using System;

namespace programmingproblems
{
    class Addition
    {
        static void Main(string[] args)
        {
            Console.Write("Input any number of your choice: ");
            decimal a = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Input another number of your choice: ");
            decimal b = Convert.ToDecimal(Console.ReadLine());

            Console.Write($"Now let's add them together:\n");
            decimal c = a + b;
            Console.WriteLine($"{a} + {b} = {c}");

            Console.WriteLine("Input a value with a decimal figure to add to the numbers above:");
            decimal d = Convert.ToDecimal(Console.ReadLine());
            decimal e = c + d;
            Console.WriteLine($"Your new value is {e}");

            Console.WriteLine("Input any number for the final time: ");
            decimal f = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Would you like to add or subtract this value to the final tally?: ");

            if (Console.ReadLine() == "add")
            {
                Console.WriteLine("Your final total is:");
                Console.WriteLine(e + f);
            }
            else if (Console.ReadLine() != "subtract")
            {
                Console.WriteLine("Your final total is:");
                Console.WriteLine(e - f);
            }
            else
            {
                Console.WriteLine($"Invalid entry, please use add or subtract for your final choice");

            }
        } 
    }
}