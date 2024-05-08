namespace Homework_W3_4
{
    using System;

    class Program
    {
        static int CalculateFine(int daysOverdue, int numBooks)
        {
            int fine = 0;
            if (daysOverdue <= 21)
            {
                fine = 0;
            }
            else if (daysOverdue <= 30)
            {
                fine = (daysOverdue - 21) * 50 * numBooks;
            }
            else
            {
                fine = (daysOverdue - 21) * 80 * numBooks;
                Console.WriteLine("Membership cancelled");
            }
            return fine;
        }

        static int CalculateDaysOverdue(int daysKept)
        {
            return daysKept - 21 > 0 ? daysKept - 21 : 0;
        }

        static void Main(string[] args)
        {
            int numBooks;
            do
            {
                Console.Write("Palun sisestage raamatute arv (max 5): ");
            } while (!int.TryParse(Console.ReadLine(), out numBooks) || numBooks < 1 || numBooks > 5);

            int daysKept;
            Console.Write("Palun sisestage mitu päaeva olete te hoidnud seda raamatut: ");
            while (!int.TryParse(Console.ReadLine(), out daysKept) || daysKept < 0)
            {
                Console.WriteLine("Invalid input. Please enter a non-negative integer.");
                Console.Write("Palun sisestage mitu päaeva olete te hoidnud seda raamatut: ");
            }

            int daysOverdue = CalculateDaysOverdue(daysKept);
            int fine = CalculateFine(daysOverdue, numBooks);

            Console.WriteLine($"Trahv: ${fine / 100.0}");
        }
    }

}