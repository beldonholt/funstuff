// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");
//------------------------------------------Himanshu
Console.WriteLine("Hello to our github project");
Console.WriteLine("In this we are three peoples working on same project");
Console.WriteLine("We have created a new repo");


//------------------------------------------Rami
RamiGreeting();

// Method defined for Rami
void RamiGreeting()
{
    Console.WriteLine("Hello from Rami!");
}
//------------------------------------------Celeste
static void funThings()
{
    Console.WriteLine("hi I'm fun things");
    Console.WriteLine("i can do many things, like counting to 100. See!");
    for (int i = 0; i < 100; i++)
    {
        Console.WriteLine($"{i}");
    }
}
funThings();

namespace Lab_4
{
    internal class CurrencyConverter
    {
        static void Main(string[] args)
        {
            //Constants for exchange rates
            const double RATE_AUD = 0.8085;
            const double RATE_USD = 0.8272;
            const double RATE_GBP = 0.5457;
            const double RATE_JPY = 76.23;
            const double RATE_EUR = 0.6297;

            Console.WriteLine("Welcome to the NZD Currency Converter!");
            Console.Write("Enter an amount in New Zealand Dollars (NZD): $");

            // Input NZD amount
            double nzd = double.Parse(Console.ReadLine());

            // Currency conversions
            double aud = nzd * RATE_AUD;
            double usd = nzd * RATE_USD;
            double gbp = nzd * RATE_GBP;
            double jpy = nzd * RATE_JPY;
            double eur = nzd * RATE_EUR;

            //// Display results with formatting
            Console.WriteLine("\nCurrency Conversion Results:");
            Console.WriteLine($"Australian Dollars (AUD): {aud:F2}");
            Console.WriteLine($"US Dollars (USD):         {usd:F2}");
            Console.WriteLine($"British Pounds (GBP):     {gbp:F2}");
            Console.WriteLine($"Japanese Yen (JPY):        {jpy:F2}");
            Console.WriteLine($"Euros (EUR):               {eur:F2}");

            Console.WriteLine("\nThank you for using the converter!");
            Console.ReadLine();
        }


    }
}//------------------------------------------End