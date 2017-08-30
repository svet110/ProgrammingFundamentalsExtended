using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamShopping
{
    public class ExamShopping
    {
        public static void Main()
        {
            var stocking = new Dictionary<string, int>();
            
            string[] command = Console.ReadLine().Split(new[] { ' ' },StringSplitOptions.RemoveEmptyEntries);
            
            while (command[0] != "shopping")
            {
                string product = command[1];
                int quantity = int.Parse(command[2]);
                if (!stocking.ContainsKey(product))
                {
                    stocking[product] = 0;
                }
                stocking[product] += quantity;
                
                command = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }
            
            string[] anotherCommand = Console.ReadLine().Split(' ');
            
            while (anotherCommand[0] != "exam")
            {
                string product = anotherCommand[1];
                int quantity = int.Parse(anotherCommand[2]);
                if (!stocking.ContainsKey(product))
                {
                    Console.WriteLine("{0} doesn't exist", product);
                }
                else
                {
                    if (stocking[product] > 0)
                    {
                        stocking[product] -= quantity;
                    }            
                    else if (stocking[product] == 0)
                    {
                        stocking[product] = 0;
                        Console.WriteLine("{0} out of stock", product);    
                    }
                    else
                    {
                        stocking[product] = 0;
                    }
                }

                anotherCommand = Console.ReadLine().Split(' ');
            }

            foreach (var stock in stocking.Where(q => q.Value > 0))
            {
                Console.WriteLine(stock);
            }
        }
    }
}
