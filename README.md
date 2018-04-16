# AnxPro.Api
A .Net Standard client for the [ANXPRO](https://anxpro.com/pages/api) V3 cryptocurrency API. 


**This is an alpha version, meaning the API is not feature complete and may contain bugs.**

In fact, it's almost a guarantee to contain bugs because I don't have any coins on this exchange.
But you can fix that part of the problem right now...

Contribute to this project by sending some XɃT my way: 1AcmMBDMTQYTzgc6E5qtA8m3GCKTR7HuiN 

## Example usage

```csharp
using System;
using AnxPro.Api;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello ANXPRO!");

            using (var client = new AnxProClient())
            {
                try
                {
                    // Get all the supported currencies.
                    var result = client.GetCurrenciesAsync().GetAwaiter().GetResult();

                    foreach (var currency in result.CurrencyStatic.Currencies)
                    {
                        Console.WriteLine(currency.Key + " - " + currency.Value.Symbol);
                    }

                    // Get all the currency pairs.
                    foreach (var pair in result.CurrencyStatic.CurrencyPairs)
                    {
                        Console.WriteLine(pair.Key + " - " + pair.Value.PreferredMarket);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine("\nPress 'Enter' Key to Continue.........");
            Console.ReadKey();
        }
    }
}

```
