using System;

namespace IterationExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Iterations exercises program.");
            Console.WriteLine("");
            Console.WriteLine("To start, we will have a variable assigned to a value, have a condition determined for it, and then have it incremented until it surpasses the condition.");
            Console.WriteLine("");
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine($"{i}");
            }
        }
    }
}
