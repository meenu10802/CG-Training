using System;

namespace CGTraining.Day1
{
    class AverageOfThree
    {
        public static void Run()
        {
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter third number: ");
            double num3 = Convert.ToDouble(Console.ReadLine());
            double avg = (num1 + num2 + num3) / 3;
            Console.WriteLine("Average of three numbers: " + avg);
        }
    }
}
