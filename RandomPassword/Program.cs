using System;

namespace RandomPassword
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Random rd = new Random();
            string password = String.Empty;

            for (int i = 0; i < 15; i++)
            {
                int randNum = rd.Next(0, 9);
                password += randNum;
            }

            Console.WriteLine(password);
        }
    }
}