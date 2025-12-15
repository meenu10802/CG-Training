using System;
namespace CGTraining.Day2
{
    class KmToMiles2
    {
        public static void Run()
        {
            double km;
            double miles;
            Console.Write("Enter distance in kilometers: ");
            km = Convert.ToDouble(Console.ReadLine());
            miles = km / 1.6;
            Console.WriteLine("The total miles is " + miles + " mile for the given " + km + " km");
        }
    }
}
