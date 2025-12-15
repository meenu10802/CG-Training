using System;
namespace CGTraining.Day2
{
    class SquareSide
    {
        public static void Run()
        {
            double perimeter;
            double side;
            Console.Write("Enter perimeter of square: ");
            perimeter = Convert.ToDouble(Console.ReadLine());
            side = perimeter / 4;
            Console.WriteLine("The length of the side is " + side + " whose perimeter is " + perimeter);
        }
    }
}
