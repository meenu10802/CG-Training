using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace CGTraining
{
    public class AddTwoNumbers
    {
        public static void Run()
        {
            Console.Write("Enter first number: ");
            int a=int.Parse(Console.ReadLine());
            Console.WriteLine("Eneter second number");
            int b=int.Parse(Console.ReadLine());
            Console.WriteLine("Sum is "+ a+b);
        }
    }
}
