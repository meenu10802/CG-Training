using System;

namespace CGTraining.Day2
{
    public class SamAveragePCM
    {
        public static double CalculateAverage()
        {
            int maths = 94;
            int physics = 95;
            int chemistry = 96;
            int total = maths + physics + chemistry;
            double average = total / 3.0;
            return average;
        }
    }
}
