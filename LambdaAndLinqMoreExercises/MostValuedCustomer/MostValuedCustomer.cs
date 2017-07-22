using System;
using System.Collections.Generic;
using System.Linq;

namespace MostValuedCustomer
{
    class MostValuedCustomer
    {
        static void Main()
        {
            var productsAndPrices = new Dictionary<string, decimal>();
            var customers = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();

            while (input != "Shop is open")
            {
                string[] tokens = input.Split(' ');
                string product = tokens[0];
                decimal price = decimal.Parse(tokens[1]);

                productsAndPrices.Add(product, price);

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "Print")
            {
                string[] inputTokens = input
                    .Split(new string[] { ": ", ", " }
                    ,StringSplitOptions.RemoveEmptyEntries);

                string customerName = inputTokens[0];
                if (!customers.ContainsKey(customerName))
                {
                    customers.Add(customerName, new List<string>());
                }

                for (int i = 1; i < inputTokens.Length; i++)
                {
                    
                }
                    
                
                
                input = Console.ReadLine();
            }
        }
    }
}
