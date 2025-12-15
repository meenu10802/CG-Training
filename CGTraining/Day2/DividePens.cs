using System;
namespace CGTraining.Day2
{
    public class DividePens
    {
        public static void Distribute()
        {
            int pens = 14;
            int students = 3;
            int pensPerStudent = pens / students;
            int remainingPens = pens % students;
            Console.WriteLine(
                "The Pen Per Student is " + pensPerStudent +
                " and the remaining pen not distributed is " + remainingPens
            );
        }
    }
}