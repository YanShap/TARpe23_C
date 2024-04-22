using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        List<string> lines = new List<string>();
        using (StreamReader sr = new StreamReader("C:Algne.txt"))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                lines.Add(line);
            }
        }

        lines.Reverse();

        using (StreamWriter sw = new StreamWriter("C:Reversed.txt"))
        {
            for (int i = 0; i < lines.Count; i++)
            {
                string numberedLine = $"{i + 1}. {lines[i]}";
                sw.WriteLine(numberedLine);
                Console.WriteLine(numberedLine);
            }
        }
    }
}