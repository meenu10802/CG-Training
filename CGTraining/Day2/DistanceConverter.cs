using System;
namespace CGTraining.Day2
{
    class DistanceConverter
    {
        public static void Run()
        {
            Console.Write("Enter distance in feet: ");
            double feet = Convert.ToDouble(Console.ReadLine());
            double yards = feet / 3;
            double miles = yards / 1760;
            Console.WriteLine("Distance in yards: " + yards + " and miles: " + miles);
        }
    }
}
