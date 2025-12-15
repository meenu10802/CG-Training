using System;

namespace CGTraining.Day1
{
    public class SimpleInterest
    {
        public static void Run()
        {
            Console.WriteLine("Enter principle: ");
            double p = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter rate of interest: ");
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter time: ");
            double t = double.Parse(Console.ReadLine());
            Console.WriteLine(p * r * t / 100);
        }
    }
}
