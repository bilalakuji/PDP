using System;

namespace programmingproblems
{
    class program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Hello, input a letter a - c");
           string letter = Console.ReadLine();
           if (letter == "a") 
           {
                Console.WriteLine("Nice");
           }
           else if (letter == "b")
           {
               Console.WriteLine("Good choice");
           }
           else if (letter == "c")
           {
               Console.WriteLine("Cool");
           }
           else
           {
                Console.WriteLine("wah wah");
           }
        }
    }
}