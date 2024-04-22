class Program
{
    static void Main(string[] args)
    {
        int secretNumber = 7;

        Console.WriteLine("Arva ära number millest ma mõtlen:");

        while (!GuessNumber(secretNumber))
        {
            Console.WriteLine("Vale number proovi uuesti:");
        }

        Console.WriteLine("Õige sa arvasid mu numbri ära!");
    }

    static bool GuessNumber(int secretNumber)
    {
        string input = Console.ReadLine();

        if (int.TryParse(input, out int guess))
        {
            if (guess == secretNumber)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            Console.WriteLine("Tundmatu number kirjuta tavaline number :");
            return false;
        }
    }
}