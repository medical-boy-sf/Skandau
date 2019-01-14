using System;

namespace AgeCategories
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("You are an adult! You can enter!");
            }
            
            else if (age >= 14)
            {
                Console.WriteLine("Underaged! You need to turn 18 to enter!");
            }

            else if (age >= 0)
            {
                Console.WriteLine("Minor! You cannot enter!");
            }

            else
            {
                Console.WriteLine("You've entered invalid age!");
            }
        }
    }
}