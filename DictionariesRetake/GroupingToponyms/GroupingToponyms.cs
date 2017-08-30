using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupingToponyms
{
    public class GroupingToponyms
    {
        public static void Main()
        {
            var toponyms = new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string continent = input[0];
                string country = input[1];
                string town = input[2];

                AddToponym(toponyms, continent, country, town);
            }

            foreach (var continent in toponyms.Keys)
            {
                Console.WriteLine("{0}:", continent);
                foreach (var country in toponyms[continent])
                {
                    Console.WriteLine("  {0} -> {1}", country.Key, string.Join(", ", country.Value));
                }
            }
        }

        public static void AddToponym(SortedDictionary<string, SortedDictionary<string, SortedSet<string>>> toponyms,
            string continent, string country, string town)
        {
            if (!toponyms.ContainsKey(continent))
            {
                toponyms[continent] = new SortedDictionary<string, SortedSet<string>>();
            }
            if (!toponyms[continent].ContainsKey(country))
            {
                toponyms[continent][country] = new SortedSet<string>();
            }

            toponyms[continent][country].Add(town);
        }
    }
}
