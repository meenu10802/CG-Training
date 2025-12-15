using System;
namespace CGTraining.Day2
{
    class HeightConverter
    {
        public static void Run()
        {
            double cm;
            double totalInches;
            int feet;
            double inches;
            Console.Write("Enter height in cm: ");
            cm = Convert.ToDouble(Console.ReadLine());
            totalInches = cm / 2.54;
            feet = (int)(totalInches / 12);
            inches = totalInches % 12;
            Console.WriteLine("Your Height in cm is " + cm + " while in feet is " + feet + " and inches is " + inches);
        }
    }
}
