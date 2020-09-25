using System;
/// <summary>
/// class for converter
/// </summary>
namespace CurrencyExchange
{
    public class Converter
    {
        double USD;
        double EUR;
        public Converter(double usd, double eur)
        {
            USD = usd;
            EUR = eur;
        }


        public void Conv()
        {
            while (true)
            {
                Console.WriteLine("Selet action:" + "\n" + "1. USD to UAH" +
                    "\n" + "2. EUR to UAH" +
                    "\n" + "3. UAH to USD" + "\n" + "4. UAH to EUR");
                int InputChoice = int.Parse(Console.ReadLine());
                if (InputChoice > 4)
                {
                    Console.WriteLine("Wrong input. Try again");
                    Console.WriteLine();
                    continue;
                }
                if(InputChoice == 0)
                {
                    break;
                }

                Console.WriteLine("Type your sum: ");
                float InputSum = float.Parse(Console.ReadLine());

                if (InputChoice == 1)
                {
                    Console.WriteLine("Your cash: " + InputSum * USD);
                    Console.WriteLine();
                }
                else if (InputChoice == 2)
                {
                    Console.WriteLine("Your cash: " + InputSum * EUR);
                    Console.WriteLine();

                }
                else if (InputChoice == 3)
                {
                    double result = InputSum / USD;
                    result = Math.Round(result, 2);
                    Console.WriteLine("Your cash: " + result);
                    Console.WriteLine();

                }
                else if (InputChoice == 4)
                {
                    double res = InputSum / EUR;
                    res = Math.Round(res, 2);
                    Console.WriteLine("Your cash: " + res);
                    Console.WriteLine();

                }
                
                
            }
        }
    }
}
