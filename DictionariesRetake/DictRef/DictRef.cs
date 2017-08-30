using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictRef
{
    public class DictRef
    {
        public static void Main()
        {
            var dict = new Dictionary<string, int>();

            string text = Console.ReadLine();

            while (text != "end")
            {
                string[] input = text.Split(new string[] { " = " }, StringSplitOptions.RemoveEmptyEntries);
                string first = input[0];
                string second = input[1];
                int value = 0;
                
                if (int.TryParse(second, out value))
                {
                    dict[first] = value;
                }
                else
                {
                    if (dict.ContainsKey(second))
                    {
                        dict[first] = dict[second];
                    }
                }                           

                text = Console.ReadLine();
            }

            foreach (var item in dict)
            {
                Console.WriteLine("{0} === {1}", item.Key, item.Value);
            }
        }
    }
}
