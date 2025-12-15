using System;

namespace CGTraining
{
    public class SimpleInterest
    {
        public static void Run()
        {
            Console.WriteLine("Enter principle: ");
            Console.WriteLine("Enter rate of interest: ");
            Console.WriteLine("Enter time: ");
            double p = double.Parse(Console.ReadLine());
            double r = double.Parse(Console.ReadLine());
            double t = double.Parse(Console.ReadLine());
            Console.WriteLine((p * r * t) / 100);
        }
    }
}
