using System;
namespace CGTraining.Day2.Level2
{
    public class QuotientAndRemainder
    {
        public static void Calculate()
        {
            Console.WriteLine("Enter first Number");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second Number");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Quotient is " + (number1 / number2) + " and Remainder is " + (number1 % number2) + " of two numbers " + number1 + " and " + number2);
        }
    }
}