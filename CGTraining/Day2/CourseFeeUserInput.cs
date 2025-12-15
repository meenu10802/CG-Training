using System;
namespace CGTraining.Day2
{
	public class CourseFeeUserInput
	{
		public static void Calculate()
		{
			int fee;
			int discountPercent;
			int discountedAmount;
			int discountedPrice;
			Console.Write("Enter course fee: ");
			fee = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter discount percentage: ");
			discountPercent = Convert.ToInt32(Console.ReadLine());
			discountedAmount = (fee * discountPercent) / 100;
			discountedPrice = fee - discountedAmount;
			Console.WriteLine("=> The discount amount is INR " + discountedAmount + " and final discounted fee is INR " + discountedPrice);
		}
	}
}
