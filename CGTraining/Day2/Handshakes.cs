using System;
namespace CGTraining.Day2
{
    class Handshakes
    {
        public static void Run()
        {
            Console.Write("Enter number of students: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int maxHandshakes = n * (n - 1) / 2;
            Console.WriteLine("Maximum number of handshakes: " + maxHandshakes);
        }
    }
}
