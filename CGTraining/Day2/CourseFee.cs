using System;
namespace CGTraining.Day2
{
    public class CourseFee
    {
        public static void Calculate()
        {
            int fee = 125000;
            int discountPercent = 10;
            int discountedAmount = (fee * discountPercent) / 100;
            int discountedPrice = fee - discountedAmount;
            Console.WriteLine("=> The discount amount is INR " + discountedAmount + " and final discounted fee is INR" + discountedPrice);
        }
    }
}