using System;
namespace CGTraining.Day2
{
    class TotalPrice
    {
        public static void Run()
        {
            Console.Write("Enter unit price: ");
            double unitPrice = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter quantity: ");
            int quantity = Convert.ToInt32(Console.ReadLine());
            double total = unitPrice * quantity;
            Console.WriteLine("The total purchase price is INR " + total + " if the quantity " + quantity + " and unit price is INR " + unitPrice);
        }
    }
}
