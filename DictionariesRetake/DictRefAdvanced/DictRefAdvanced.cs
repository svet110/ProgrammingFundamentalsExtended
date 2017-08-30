using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictRefAdvanced
{
    public class DictRefAdvanced
    {
        public static void Main()
        {
            var dict = new Dictionary<string, List<int>>();
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input.Split(new[] { ' ', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries);
                string key = tokens[0];
                int value = 0;

                if (int.TryParse(tokens[1], out value))
                {
                    if (!dict.ContainsKey(key))
	                {
                        dict[key] = new List<int>();
	                }

                    for (int i = 1; i < tokens.Length; i++)
                    {
                        dict[key].Add(int.Parse(tokens[i]));
                    }
                }
                else
	            {
                    string otherKey = tokens[1];
                    if (dict.ContainsKey(otherKey))
                    {
                        dict[key] = new List<int>(dict[otherKey]);
                    }
	            }                

                input = Console.ReadLine();
            }

            foreach (var item in dict)
            {
                Console.WriteLine("{0} === {1}", item.Key, string.Join(", ", item.Value));
            }
        }
    }
}
