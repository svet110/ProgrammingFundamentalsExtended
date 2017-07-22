using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    class ShoppingSpree
    {
        static void Main()
        {
            var productsAndPrices = new Dictionary<string, decimal>();
            decimal budget = decimal.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(' ');

            while (input[0] != "end")
            {
                string product = input[0];
                decimal price = decimal.Parse(input[1]);

                if (productsAndPrices.ContainsKey(product))
                {
                    if (productsAndPrices[product] > price)
                    {
                        productsAndPrices[product] = price;
                    }
                }
                else
                {
                    productsAndPrices[product] = price;
                }

                input = Console.ReadLine().Split(' ');
            }

            decimal totalPrice = productsAndPrices.Sum(r => r.Value);

            if (totalPrice > budget)
            {
                Console.WriteLine("Need more money... Just buy banichka");
            }
            else
            {
                Dictionary<string, decimal> sorted = productsAndPrices
                    .OrderByDescending(p => p.Value)
                    .ThenBy(p => p.Key.Length)
                    .ToDictionary(p => p.Key, p => p.Value);

                foreach (var pair in sorted)
                {
                    Console.WriteLine("{0} costs {1:f2}", pair.Key, pair.Value);
                }
            }
        }
    }
}
