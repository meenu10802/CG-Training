using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGTraining.Day1
{
    internal class CelsiusToFahrenheit
    {
        public static void Run()
        {
            Console.Write("Enter Celsius: ");
            double c=double.Parse(Console.ReadLine());

            double f = c *9/5+32;
            Console.WriteLine("Fahrenheit= " + f);
            Console.WriteLine();
        }
    }
}
