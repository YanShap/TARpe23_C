using System;
using System.IO;

namespace Homework_W3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteSquareOfNumbers(2);
        }

        static void WriteSquareOfNumbers(int number)
        {
            string row = new string(Convert.ToChar(number.ToString()), number);

            string square = string.Join(Environment.NewLine, new string[number].Select(_ => row));

            File.WriteAllText("square.txt", square);

            Console.WriteLine("Arvud on failis kirjas");
        }
    }
}