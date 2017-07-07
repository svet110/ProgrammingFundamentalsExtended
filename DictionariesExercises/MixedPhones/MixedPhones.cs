using System;
using System.Collections.Generic;
using System.Linq;

namespace MixedPhones
{
    class MixedPhones
    {
        static void Main()
        {
            var dict = new SortedDictionary<string, long>();
            string input = Console.ReadLine();

            while (input != "Over")
            {
                var tokens = input.Split(" :".ToCharArray()
                    , StringSplitOptions.RemoveEmptyEntries);
                var firstElement = tokens[0];
                var secElement = tokens[1];

                long number = 0L;

                if (long.TryParse(firstElement, out number))
                {
                    var key = secElement;
                    var value = number;                    
                    dict[key] = number;
                }
                else
                {
                    var key = firstElement;
                    var value = long.Parse(secElement); 
                    dict[firstElement] = value;
                }

                input = Console.ReadLine();
            }

            foreach (var item in dict)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }
    }
}
