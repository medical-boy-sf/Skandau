using System;

namespace BMI
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double weight = Double.Parse(Console.ReadLine());
            double height = Double.Parse(Console.ReadLine());
            double bmi = weight / (height * height);
            Console.WriteLine($"Your BMI is {bmi:F2}");

            if (bmi >= 25)
            {
                Console.WriteLine("Overweight!");
            }
            
            else if (bmi > 18)
            {
                Console.WriteLine($"Normal weight.");
            }

            else
            {
                Console.WriteLine("Underweight! Eat more! ");
            }
        }
    }
}