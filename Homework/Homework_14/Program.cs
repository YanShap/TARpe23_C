namespace Homework_14

class Program
{
    static void Main()
    {
        DrawDiamond(7);
    }

    static void DrawDiamond(int rows)
    {
        int n = rows / 2;

        for (int i = 0; i <= n; i++)
        {
            for (int j = 0; j < n - i; j++)
                Console.Write(" ");
            for (int k = 0; k < 2 * i + 1; k++)
                Console.Write("*");
            Console.WriteLine();
        }

        for (int i = n - 1; i >= 0; i--)
        {
            for (int j = 0; j < n - i; j++)
                Console.Write(" ");
            for (int k = 0; k < 2 * i + 1; k++)
                Console.Write("*");
            Console.WriteLine();
        }
    }
}