namespace Homework_w9
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            VATCalculator calculator = new VATCalculator();

            calculator.SetVATRate(20);

            double price = 20;
            double vat = calculator.FindVATFromPrice(price);
            Console.WriteLine($"Käibemaks hinnast {price} on {vat}");

            double priceWithoutTax = calculator.FindPrice(true, 20);
            Console.WriteLine($"Hind ilma käibemaksuta {price} on {priceWithoutTax}");

            double priceWithTax = calculator.FindPrice(false, 20);
            Console.WriteLine($"Hind käibemaksuga {price} on {priceWithTax}");

            double priceBasedOnTax = calculator.FindPriceBasedOnTax(4);
            Console.WriteLine($"Hind sõltuv käibemaksust {4} on {priceBasedOnTax}");

            bool is20Percent = calculator.IsTaxPercent20();
            Console.WriteLine($"Kas käibemaks on 20%? {is20Percent}");

            calculator.SetVATRate(9);
            is20Percent = calculator.IsTaxPercent20();
            Console.WriteLine($"Kas käibemaks on 20% praegu? {is20Percent}");
        }
    }

    class VATCalculator
    {
        private double vatRate = 0.20;

        public void SetVATRate(double rate)
        {
            vatRate = rate / 100;
        }

        public double FindVATFromPrice(double price)
        {
            return price * vatRate;
        }

        public double FindPrice(bool isWithTax, double amount)
        {
            if (isWithTax)
            {
                return amount / (1 + vatRate);
            }
            else
            {
                return amount * (1 + vatRate);
            }
        }

        public double FindPriceBasedOnTax(double taxAmount)
        {
            return taxAmount / vatRate;
        }

        public bool IsTaxPercent20()
        {
            return Math.Abs(vatRate - 0.20) < 0.0001;
        }
    }
}