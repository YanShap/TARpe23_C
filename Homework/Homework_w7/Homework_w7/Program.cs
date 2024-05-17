namespace Homework_w7

public interface IIroningMachine
{
    void Descale();
    void DoIroning(int temperature);
    void DoIroning(string program);
    void UseSteam();
    void TurnOn();
    void TurnOff();
}
public class IroningMachine : IIroningMachine
{
    protected int usageCounter;
    protected bool steamUsed;
    protected bool steamIndicatorLight;
    protected bool isOn;

    public IroningMachine()
    {
        usageCounter = 0;
        steamUsed = false;
        steamIndicatorLight = false;
        isOn = false;
    }

    public virtual void Descale()
    {
        usageCounter = 0;
        Console.WriteLine("Triikraud on puhastatud.");
    }

    public virtual void DoIroning(int temperature)
    {
        if (!isOn)
        {
            Console.WriteLine("Lülitage triikraud ennem tööle.");
            return;
        }

        if (steamUsed)
        {
            Console.WriteLine("Triikimine auruga");
            steamUsed = false;
        }

        Console.WriteLine($"Triikimine {temperature} kraadiga.");
        usageCounter++;
        if (usageCounter == 3)
        {
            Descale();
        }
    }

    public virtual void DoIroning(string program)
    {
        int minTemperature = 0;
        int maxTemperature = 0;

        switch (program.ToLower())
        {
            case "linen":
                minTemperature = 200;
                maxTemperature = 230;
                break;
            case "cotton":
                minTemperature = 150;
                maxTemperature = 199;
                break;
            case "silk":
                minTemperature = 120;
                maxTemperature = 149;
                break;
            case "synthetics":
                minTemperature = 90;
                maxTemperature = 119;
                break;
            default:
                Console.WriteLine($"Tundmatu programm: {program}");
                return;
        }

        Random rnd = new Random();
        int randomTemperature = rnd.Next(minTemperature, maxTemperature + 1);

        DoIroning(randomTemperature);
    }

    public virtual void UseSteam()
    {
        if (isOn)
        {
            if (steamUsed)
            {
                Console.WriteLine("Auru funktsioon on juba sees.");
            }
            else
            {
                if (usageCounter > 0)
                {
                    steamUsed = true;
                    usageCounter++;
                    if (usageCounter == 2)
                    {
                        steamIndicatorLight = true;
                        Console.WriteLine("Vee indikaator hakkas põlema. Palun lisage vett.");
                    }
                }
                else
                {
                    Console.WriteLine("Ei saa kasutada auru enne triikimist.");
                }
            }
        }
        else
        {
            Console.WriteLine("Pane triikraud ennem tööle.");
        }
    }

    public virtual void TurnOn()
    {
        isOn = true;
        Console.WriteLine("Triikraud on sisse lülitatud.");
    }

    public virtual void TurnOff()
    {
        isOn = false;
        Console.WriteLine("Triikraud on välja lülitatud.");
    }
}

public class RegularIron : IroningMachine
{
    public override void Descale()
    {
        base.Descale();
        Console.WriteLine("Triikraud on kasutatud 3 korda, puhastus on kohustuslik.");
    }
}

public class PremiumIron : IroningMachine
{
    public override void Descale()
    {
        base.Descale();
        Console.WriteLine("Triikraud on kasutatud 3 korda, puhastus on kohustuslik.");
    }

    public override void DoIroning(int temperature)
    {
        base.DoIroning(temperature);
        if (usageCounter == 3)
        {
            Descale();
        }
    }
}
public class LinenIron : IroningMachine
{
    public override void DoIroning(int temperature)
    {
        base.DoIroning(temperature);
        if (temperature >= 120)
        {
            steamUsed = true;
            Console.WriteLine("Triikimine auruga");
        }
    }
}
public class IroningProgram
{
    public static void Main(string[] args)
    {
        RegularIron regularIron = new RegularIron();
        PremiumIron premiumIron = new PremiumIron();
        LinenIron linenIron = new LinenIron();

        regularIron.TurnOn();
        regularIron.DoIroning("puuvill");
        regularIron.UseSteam();
        regularIron.DoIroning("siid");

        premiumIron.TurnOn();
        premiumIron.DoIroning(180);
        premiumIron.DoIroning("puuvill");
        premiumIron.UseSteam();
        premiumIron.UseSteam();
        premiumIron.DoIroning("sünteetika");

        linenIron.TurnOn();
        linenIron.DoIroning("lina");
        linenIron.DoIroning(210);
        linenIron.DoIroning(220);
        linenIron.UseSteam();
    }
}