using System;
using System.Linq;
using System.Collections.Generic;
					
public class ExamShopping
{
	public static void Main()
	{
		var stock = new Dictionary<string, long>();
		string input = Console.ReadLine();
		
		while (input != "shopping time")
		{
			var tokens = input.Split(' '); 
			var product = tokens[1];
			var quantity = tokens[2];
			
			long number = 0;
			if (long.TryParse(quantity, out number))
			{
				if (!stock.ContainsKey(product))
				{
					stock[product] = number;
				}
				else
				{
					stock[product] += number;
				}
			}
			
			input = Console.ReadLine();
		}
		
		input = Console.ReadLine();
		
		while (input != "exam time")
		{
			var tokens = input.Split(' '); 
			var product = tokens[1];
			var quantity = int.Parse(tokens[2]);
			
			if (!stock.ContainsKey(product))
            {
                Console.WriteLine("{0} doesn't exist", product);
            }
            else
            {
                if(stock[product] == 0)
                {
                    Console.WriteLine("{0} out of stock", product);
                }
                else
                {
                    stock[product] -= quantity;

                    if(stock[product] < 0)
                    {
                    	stock[product] = 0;
                    }
                }
            }
			
			input = Console.ReadLine();
		}
		
		foreach (var item in stock)
		{
			if (item.Value > 0)
			{
				Console.WriteLine("{0} -> {1}", item.Key, item.Value);
			}		
		}
	}
}