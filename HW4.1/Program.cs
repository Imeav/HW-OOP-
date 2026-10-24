
using System;

Converter converter;

while (true)
{
    try
    {
        Console.Write("Enter USD rate in UAH: ");
        decimal usd = decimal.Parse(Console.ReadLine() ?? "");

        Console.Write("Enter EUR rate in UAH: ");
        decimal eur = decimal.Parse(Console.ReadLine() ?? "");

        switch (usd)
        {
            case <= 0:
                throw new ArgumentException("USD rate must be positive!");
        }

        switch (eur)
        {
            case <= 0:
                throw new ArgumentException("EUR rate must be positive!");
        }

        converter = new Converter(usd, eur);
        break;
    }
    catch (FormatException)
    {
        Console.WriteLine("Please enter a valid number!");
    }
    catch (OverflowException)
    {
        Console.WriteLine("The number is too large!");
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine(ex.Message);
    }
}

while (true)
{
    Console.WriteLine("1. UAH to USD");
    Console.WriteLine("2. USD to UAH");
    Console.WriteLine("3. UAH to EUR");
    Console.WriteLine("4. EUR to UAH");

    Console.Write("Choose option: ");

    try
    {
        int choice = int.Parse(Console.ReadLine() ?? "");

        switch (choice)
        {
            case 1:
                {
                    decimal amount = ReadAmount();
                    decimal result = converter.UahToUsd(amount);

                    Console.WriteLine($"Result: {result:F2} USD");
                    break;
                }

            case 2:
                {
                    decimal amount = ReadAmount();
                    decimal result = converter.UsdToUah(amount);

                    Console.WriteLine($"Result: {result:F2} UAH");
                    break;
                }

            case 3:
                {
                    decimal amount = ReadAmount();
                    decimal result = converter.UahToEur(amount);

                    Console.WriteLine($"Result: {result:F2} EUR");
                    break;
                }

            case 4:
                {
                    decimal amount = ReadAmount();
                    decimal result = converter.EurToUah(amount);

                    Console.WriteLine($"Result: {result:F2} UAH");
                    break;
                }

            default:
                Console.WriteLine("Invalid option!");
                break;
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Please enter a valid number!");
    }
    catch (OverflowException)
    {
        Console.WriteLine("The number is too large!");
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine(ex.Message);
    }
}


static decimal ReadAmount()
{
    Console.Write("Enter amount: ");

    decimal amount = decimal.Parse(Console.ReadLine() ?? "");

    switch (amount)
    {
        case < 0:
            throw new ArgumentException("Amount cannot be negative!");
    }

    return amount;
}

