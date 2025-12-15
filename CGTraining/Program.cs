using System;
using CGTraining.Day1;

class Program
{
    static void Main()
    {
        Welcome.Print();
        AddTwoNumbers.Run();
        CelsiusToFahrenheit.Run();
        AreaOfCircle.Run();
        VolumeOfCylinder.Run();
        SimpleInterest.Run();
        RectanglePerimeterWithoutMainMeth.Run();
        PowerCalculation.Run();
        AverageOfThree.Run();
        KmToMiles.Run();
        int harryAge = FindAge.CalculateAge();
        Console.WriteLine("Harry's age in 2024 is " + harryAge);

        double samAverage = SamAveragePCM.CalculateAverage();
        Console.WriteLine("Sam's average mark in PCM is " + samAverage);
    }
}
