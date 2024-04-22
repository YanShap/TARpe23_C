class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Helper("Rong"));
        Console.WriteLine(Helper("Arv"));
        Console.WriteLine(Helper("Kalad"));
        Console.WriteLine(Helper("A"));
        Console.WriteLine(Helper("C#"));
        Console.WriteLine(Helper("Programeerimine"));
    }

    static string Helper(string word)
    {
        if (word.Length < 2)
        {
            return "Sõna on liiga lühike!";
        }

        string result = "";

        for (int i = 0; i < word.Length; i += 2)
        {
            result += word[i];
        }

        return result;
    }