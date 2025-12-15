using System;
namespace CGTraining.Day2
{
    class BasicCalculator
    {
        public static void Run()
        {
            double number1;
            double number2;
            double addition;
            double subtraction;
            double multiplication;
            double division;
            Console.Write("Enter first number: ");
            number1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
            number2=Convert.ToDouble(Console.ReadLine());
            addition=number1+number2;
            subtraction=number1-number2;
            multiplication=number1*number2;
            division=number1/number2;
            Console.WriteLine("The addition, subtraction, multiplication and division value of 2 numbers " +number1+ " and "+number2+" is "+addition+ ", " +subtraction + ", "+multiplication+", and "+division);
        }
    }
}
