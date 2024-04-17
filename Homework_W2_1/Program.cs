internal class Program
{
        
        static void Main(string[] args)
        {
        double result1 = FindPercentage(60, 50);
        double result2 = FindPercentage(35, 1);

        Console.WriteLine(result1);
        Console.WriteLine(result2);
        }

        
        static double FindPercentage(double number, double percentage)
        {
            return (percentage / 100) * number;
        }
}