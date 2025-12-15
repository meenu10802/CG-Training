using System;

namespace CGTraining.Day1
{
    class RectanglePerimeterWithoutMainMeth
    {
        public static void Run()
        {
            Console.Write("Enter length of rectangle: ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter width of rectangle: ");
            double width = Convert.ToDouble(Console.ReadLine());
            double perimeter = 2 * (length + width);
            Console.WriteLine("Perimeter of rectangle: " + perimeter);
        }
    }
}
