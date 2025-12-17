using System;
using CGTraining.Day1;
using CGTraining.Day2;
using CGTraining.Day2.Level2;
using CGTraining.Day2.ExtraQuestions;
namespace CGTraining
{
    class Program
    {
        static void Main()
        {
            //Welcome.Print();
            //AddTwoNumbers.Run();
            //CelsiusToFahrenheit.Run();
            //AreaOfCircle.Run();
            //VolumeOfCylinder.Run();
            //SimpleInterest.Run();
            //RectanglePerimeterWithoutMainMeth.Run();
            //PowerCalculation.Run();
            //AverageOfThree.Run();
            //KmToMiles.Run();

            //FindAge.CalculateAge();
            //double samAverage = SamAveragePCM.CalculateAverage();
            //Console.WriteLine("Sam's average mark in PCM is " + samAverage);
            //Console.WriteLine("Miles: " + ConvertKmToMiles.Run());
            //ProfitLoss.Run();
            //DividePens.Distribute();
            //CourseFee.Calculate();
            //VolumeOfEarth.Calculate();
            //KmToMiles2.Run();
            //CourseFeeUserInput.Calculate();
            //HeightConverter.Run();
            //TriangleArea.Run();
            //SquareSide.Run();
            //DistanceConverter.Run();
            //TotalPrice.Run();
            //Handshakes.Run();
            //Level 2
            // QuotientAndRemainder.Calculate();

            //PositiveOrNegative.Run();
            //ATM.check();
            //PasswordStrengthChecker.checkStrength();
            //absoluteValue.flipped();
            //divisibilityTest.isDivisbleOrNot();
            //Temperature.checkTemperature();
            //Restaurant.Open();

            //Console.WriteLine("Addition: " + Calculator.Add(10, 5));
            //Console.WriteLine("Subtraction: " + Calculator.Subtract(10, 5));
            QuotientAndRemainder.Calculate();
            IntOperation.PerformIntOperations();
            DoubleOpt.PerformDoubleOperations();
            CelsiusToFahrenheit2.ConvertTemp();
            FahrenheitToCelsius.ConvertTemp();
            TotalIncome.CalculateIncome();
            SwapNumbers.Swap();
            TripDetails.ShowTrip();
            TriangularParkRounds.CalculateRounds();
            ChocolateDistribution.Distribute();
            SimpleInterest2.CalculateSI();
            WeightConversion.ConvertPoundsToKg();
            UserService.Print();
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
