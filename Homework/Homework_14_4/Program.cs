namespace Homework_14_4

using System.Text.RegularExpressions;

public class UserAccountSystem
{
    public static void Main(string[] args)
    {
        Console.WriteLine(CreateUsername("Juhan Juurikas") == "juhan.juurikas");
        Console.WriteLine(CreateUsername("Juhan Märt Juurikas") == "juhanmart.juurikas");

        Console.WriteLine(CreateEmailAccount("Juhan Juurikas company") == "juhan.juurikas@company.eu");
        Console.WriteLine(CreateEmailAccount("Juhan Märt Juurikas company") == "juhanmart.juurikas@company.eu");

        Console.WriteLine(CreateDomainAccount("Juhan Juurikas company") == "company/juhan.juurikas");
        Console.WriteLine(CreateDomainAccount("Juhan Märt Juurikas company") == "company/juhanmart.juurikas");

        Console.WriteLine(FindUserName("juhan.juurikas@company.eu") == "Name: Juhan Juurikas Domain: company");
        Console.WriteLine(FindUserName("company/juhan.juurikas") == "Name: Juhan Juurikas Domain: company");
    }

    public static string CreateUsername(string fullName)
    {
        string[] nameParts = fullName.Split(' ');
        string forename = string.Join("", nameParts, 0, nameParts.Length - 1).ToLower();
        string lastName = nameParts[nameParts.Length - 1].ToLower();

        forename = ReplaceSpecialCharacters(forename);
        lastName = ReplaceSpecialCharacters(lastName);

        string username = forename + "." + lastName;
        if (username.Length > 15)
        {
            username = username.Substring(0, 15);
        }

        return username;
    }

    public static string CreateEmailAccount(string input)
    {
        string[] parts = input.Split(' ');
        string domain = parts[parts.Length - 1];
        string fullName = string.Join(" ", parts, 0, parts.Length - 1);

        string username = CreateUsername(fullName);
        return $"{username}@{domain}.eu";
    }

    public static string CreateDomainAccount(string input)
    {
        string[] parts = input.Split(' ');
        string domain = parts[parts.Length - 1];
        string fullName = string.Join(" ", parts, 0, parts.Length - 1);

        string username = CreateUsername(fullName);
        return $"{domain}/{username}";
    }

    public static string FindUserName(string account)
    {
        string username, domain, name;

        if (account.Contains("@"))
        {
            var match = Regex.Match(account, @"^(?<username>[^@]+)@(?<domain>[^.]+)\.eu$");
            username = match.Groups["username"].Value;
            domain = match.Groups["domain"].Value;
        }
        else
        {
            var match = Regex.Match(account, @"^(?<domain>[^/]+)/(?<username>.+)$");
            username = match.Groups["username"].Value;
            domain = match.Groups["domain"].Value;
        }

        string[] nameParts = username.Split('.');
        string[] forenameParts = Regex.Split(nameParts[0], @"(?<=.)(?=[A-Z])");
        name = string.Join(" ", forenameParts) + " " + nameParts[1];

        name = CapitalizeName(name);

        return $"Name: {name} Domain: {domain}";
    }

    private static string ReplaceSpecialCharacters(string input)
    {
        return input.Replace('ä', 'a').Replace('ü', 'u').Replace('õ', 'o').Replace('ö', 'o');
    }

    private static string CapitalizeName(string input)
    {
        string[] words = input.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length > 0)
            {
                words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1);
            }
        }
        return string.Join(" ", words);
    }
}