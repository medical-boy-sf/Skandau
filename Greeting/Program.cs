using System;

namespace Greeting
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}! Welcome!");
        }
    }
}