using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGTraining
{
    internal class AreaOfCircle
    {
        public static void Run()
        {
            Console.Write("Enter radius: ");
            double r = double.Parse(Console.ReadLine());

            double area = Math.PI * r * r;
            Console.WriteLine("Area = " + area);
            Console.WriteLine();
        }
    }
}
