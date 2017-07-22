using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesReport
{
    public class Sale
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }

        public static Sale Parse(string saleAsString)
        {
            var input = saleAsString.Split(' ');

            return new Sale
            {
                Town = input[0],
                Product = input[1],
                Price = decimal.Parse(input[2]),
                Quantity = decimal.Parse(input[3])
            };
        }
    }

    public class SalesReport
    {        
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var salesByTown = new SortedDictionary<string, decimal>();
            
            for (int i = 0; i < n; i++)
            {
                var currentSaleAsString = Console.ReadLine();
                var currentSale = Sale.Parse(currentSaleAsString);

                if (!salesByTown.ContainsKey(currentSale.Town))
                {
                    salesByTown[currentSale.Town] = 0;
                }

                salesByTown[currentSale.Town] += currentSale.Price * currentSale.Quantity;
            }

            foreach (var sale in salesByTown)
            {
                Console.WriteLine("{0} -> {1:f2}", sale.Key, sale.Value);
            }
        }        
    }
}
