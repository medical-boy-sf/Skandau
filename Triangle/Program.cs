using System;

namespace Triangle
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(new string(' ', n - i) + new string('*', 2 * i - 1));
            }
        }
    }
}