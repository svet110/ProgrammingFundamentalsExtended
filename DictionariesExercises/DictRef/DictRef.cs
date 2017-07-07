using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictRef
{
    class DictRef
    {
        static void Main()
        {
            var dict = new Dictionary<string, int>();

            string[] input = Console.ReadLine().Split(new char[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries);


            while (input[0] != "end")
            {
                string key = input[0];
                string valueInput = input[1];

                int number = 0;

                if (int.TryParse(valueInput, out number))
                {
                    dict[key] = number;
                }
                else
                {
                    if (dict.ContainsKey(valueInput))
                    {
                        dict[key] = dict[valueInput];
                    }
                }

                input = Console.ReadLine().Split(new char[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var item in dict)
            {
                Console.WriteLine("{0} === {1}", item.Key, item.Value);
            }
        }
    }
}
