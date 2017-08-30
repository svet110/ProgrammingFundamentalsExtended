using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixedPhones
{
    class MixedPhones
    {
        static void Main()
        {
            var phoneBook = new SortedDictionary<string, long>();
            string text = Console.ReadLine();
            while (text != "Over")
            {
                string[] tokens = text.Split(new[] { " : " }, StringSplitOptions.RemoveEmptyEntries);
                var first = tokens[0];
                var second = tokens[1];
                long number = 0;

                if (long.TryParse(first, out number))
                {
                    var key = second;
                    var value = number;
                    phoneBook[key] = number;
                }
                else 
                {
                    var key = first;
                    var value = long.Parse(second); 
                    phoneBook[first] = value;
                }
                
                text = Console.ReadLine();
            }

            foreach (var phone in phoneBook)
            {
                Console.WriteLine("{0} -> {1}", phone.Key, phone.Value);
            }
        }
    }
}
