using System;

namespace CGTraining.Day1
{
    class KmToMiles
    {
        public static void Run()
        {
            Console.Write("Enter distance in kilometers: ");
            double km = Convert.ToDouble(Console.ReadLine());
            double miles = km * 0.621371;
            Console.WriteLine(km + " kilometers is " + miles + " miles");
        }
    }
}
