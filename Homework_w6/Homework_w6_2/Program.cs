namespace Homework_w6_2

public class BankCard
{
    static void Main(string[] args)
    {
        BankCard card1 = new BankCard();
        BankCard card2 = new BankCard(100, "Maestro");

        card1.SetCardNumber("12345678");
        card2.SetCardNumber("123");

        card1.AddMoney(50);
        card1.PrintAccountBalance();

        card1.SubtractMoney(30);
        card1.PrintAccountBalance();
        card1.SubtractMoney(60);

        card1.PrintCardType();
        card2.PrintCardType();
    }

    private double Kontojääk;
    private string Kaarditüüp;
    private string Kaardinumber;

    public BankCard()
    {
        Kontojääk = 0;
        Kaarditüüp = "Visa";
    }

    public BankCard(double balance, string type)
    {
        Kontojääk = balance;
        Kaarditüüp = type;
    }

    public void SetCardNumber(string number)
    {
        if (number.Length != 8)
        {
            Console.WriteLine("Vale number sisestatud! Kaardil peab olema 8 numbrit!");
        }
        else
        {
            Kaardinumber = number;
            Console.WriteLine($"Kaardi number {Kaardinumber} sisestatud edukalt.");
        }
    }

    public void PrintCardType()
    {
        Console.WriteLine($"Kaarditüüp: {Kaarditüüp}");
    }

    public void PrintAccountBalance()
    {
        Console.WriteLine($"Kontojääk: {Kontojääk}");
    }

    public double GetAccountBalance()
    {
        return Kontojääk;
    }

    public void AddMoney(double amount)
    {
        Kontojääk += amount;
    }

    public void SubtractMoney(double amount)
    {
        if (Kontojääk - amount < 0)
        {
            Console.WriteLine("Ei saa teostada makset, pole piisavalt vahendeid");
        }
        else
        {
            Kontojääk -= amount;
        }
    }
}