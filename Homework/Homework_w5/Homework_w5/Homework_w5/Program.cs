namespace Homework_w5
{
    static void Main(string[] args)
    {
        PrintIdCodeInfo("50703167024");
        // ReadCodesFromFile("file.txt");
    }

    static void PrintIdCodeInfo(string idCode)
    {
        try
        {
            if (!ValidateIdCode(idCode))
            {
                Console.WriteLine("Tundmatu isikukood.");
                return;
            }

            Console.WriteLine($"Kasutatav isikukood {idCode}");

            PrintBirthDate(idCode);
            PrintSex(idCode);
            PrintBirthPlace(idCode);
            PrintBirthNumber(idCode);
            PrintCheckNumber(idCode);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    static void PrintBirthDate(string idCode)
    {
        int year = GetYear(idCode);
        int month = int.Parse(idCode.Substring(3, 2));
        int day = int.Parse(idCode.Substring(5, 2));

        Console.WriteLine($"Sünnipäev on: {day:D2}.{month:D2}.{year}");
    }

    static void PrintSex(string idCode)
    {
        int sexDigit = int.Parse(idCode.Substring(0, 1));
        string sex = (sexDigit % 2 == 0) ? "naine" : "mees";

        Console.WriteLine($"Sugu: {sex}");
    }

    static void PrintBirthPlace(string idCode)
    {
        int placeCode = int.Parse(idCode.Substring(7, 3));
        string birthPlace = GetBirthPlace(placeCode);

        Console.WriteLine($"Sündimis koht: {birthPlace}");
    }

    static void PrintBirthNumber(string idCode)
    {
        int birthNumber = int.Parse(idCode.Substring(10, 1));

        Console.WriteLine($"Sündimise nr: {birthNumber}");
    }

    static void PrintCheckNumber(string idCode)
    {
        int checkNumber = int.Parse(idCode.Substring(10, 1));

        Console.WriteLine($"Kontroll nr: {checkNumber}");
    }

    static bool ValidateIdCode(string idCode)
    {
        if (idCode.Length != 11)
        {
            return false;
        }
        return true;
    }

    static int GetYear(string idCode)
    {
        int firstDigit = int.Parse(idCode.Substring(0, 1));

        int year;
        if (firstDigit < 3)
        {
            year = 1800 + int.Parse(idCode.Substring(1, 2));
        }
        else if (firstDigit < 5)
        {
            year = 1900 + int.Parse(idCode.Substring(1, 2));
        }
        else
        {
            year = 2000 + int.Parse(idCode.Substring(1, 2));
        }

        return year;
    }

    static string GetBirthPlace(int placeCode)
    {
        if (placeCode >= 1 && placeCode <= 10)
        {
            return "Kuressaare haigla";
        }
        else if (placeCode >= 11 && placeCode <= 19)
        {
            return "Tartu Ülikooli Naistekliinik";
        }
        else if (placeCode >= 21 && placeCode <= 150)
        {
            return "Ida-Tallinna keskhaigla, Pelgulinna sünnitusmaja (Tallinn)";
        }
        else if (placeCode >= 151 && placeCode <= 160)
        {
            return "Keila haigla";
        }
        else if (placeCode >= 161 && placeCode <= 220)
        {
            return "Rapla haigla, Loksa haigla, Hiiumaa haigla (Kärdla)";
        }
        else if (placeCode >= 221 && placeCode <= 270)
        {
            return "Ida-Viru keskhaigla (Kohtla-Järve, endine Jõhvi)";
        }
        else if (placeCode >= 271 && placeCode <= 370)
        {
            return "Maarjamõisa kliinikum (Tartu), Jõgeva haigla";
        }
        else if (placeCode >= 371 && placeCode <= 420)
        {
            return "Narva haigla";
        }
        else if (placeCode >= 421 && placeCode <= 470)
        {
            return "Pärnu haigla";
        }
        else if (placeCode >= 471 && placeCode <= 490)
        {
            return "Haapsalu haigla";
        }
        else if (placeCode >= 491 && placeCode <= 520)
        {
            return "Järvamaa haigla (Paide)";
        }
        else if (placeCode >= 521 && placeCode <= 570)
        {
            return "Rakvere haigla, Tapa haigla";
        }
        else if (placeCode >= 571 && placeCode <= 600)
        {
            return "Valga haigla";
        }
        else if (placeCode >= 601 && placeCode <= 650)
        {
            return "Viljandi haigla";
        }
        else if (placeCode >= 651 && placeCode <= 700)
        {
            return "Lõuna-Eesti haigla (Võru), Põlva haigla";
        }
        else
        {
            return "Sünnikoht on teadmatu";
        }
    }


    static void ReadCodesFromFile(string fileName)
    {
        try
        {
            string[] idCodes = File.ReadAllLines(fileName);

            foreach (string idCode in idCodes)
            {
                PrintIdCodeInfo(idCode);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Viga faili lugemises: {ex.Message}");
        }
    }
}
