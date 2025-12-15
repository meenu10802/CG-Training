using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGTraining.Day1
{
   public class VolumeOfCylinder
    {
        public static void Run()
        {
            Console.WriteLine("Enter radiues and height");
            double r = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.PI * r * r * h);
        }
    }
}
