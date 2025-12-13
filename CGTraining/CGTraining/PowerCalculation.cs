using System;

namespace CGTraining
{
    class PowerCalculation
    {
        public static void Run()
        {
            Console.Write("Enter base number: ");
            double baseNum = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter exponent: ");
            double exponent = Convert.ToDouble(Console.ReadLine());
            double result = Math.Pow(baseNum, exponent);
            Console.WriteLine(baseNum + " raised to " + exponent + " is " + result);
        }
    }
}
