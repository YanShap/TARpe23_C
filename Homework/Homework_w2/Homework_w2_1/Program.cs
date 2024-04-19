using System;

namespace Homework_w2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double result1 = FindPercentage(40, 50 );
            Console.WriteLine(result1);

            double result2 = FindPercentage(30, 1);
            Console.WriteLine(result2);

        }
        public static double FindPercentage(double first,double second)
		{
            double result  = 0;
            result = first * second / 100;

            return result;
		}
    }
}
