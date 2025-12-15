using System;
namespace CGTraining.Day2
{
    class TriangleArea
    {
        public static void Run()
        {
            double baseInches;
            double heightInches;
            double areaInSqInches;
            double areaInSqCm;
            Console.Write("Enter base in inches: ");
            baseInches = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter height in inches: ");
            heightInches = Convert.ToDouble(Console.ReadLine());
            areaInSqInches = 0.5 * baseInches * heightInches;
            //1 inch = 2.54 cm so square inch was given 2.54*2.54=6.4516
            areaInSqCm = areaInSqInches * 6.4516;
            Console.WriteLine("The area of triangle in square inches is " + areaInSqInches + " and in square centimeters is " + areaInSqCm);
        }
    }
}
