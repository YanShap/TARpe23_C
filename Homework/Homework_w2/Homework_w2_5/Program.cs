namespace PrintCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintCharacters();
        }
        public static void PrintCharacters()
        {
            for (int i = 7; i > 0; i--)
            {
                for (int a = 0; a < i; a++)

                {
                    Console.WriteLine("*");
                }
                Console.WriteLine();
            }
        }
    }
}