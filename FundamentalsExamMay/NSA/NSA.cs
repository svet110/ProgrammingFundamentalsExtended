using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSA
{
    public class NSA
    {
        public static void Main()
        {
            var spies = new Dictionary<string, Dictionary<string, long>>();
            string input = Console.ReadLine();
           
            while (input != "quit")
            {
                string[] tokens = input.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                string country = tokens[0];
                string spy = tokens[1];
                long daysInService = long.Parse(tokens[2]);

                if (!spies.ContainsKey(country))
                {
                    spies.Add(country, new Dictionary<string, long>());
                }
                
                if (!spies[country].ContainsKey(spy))
                {
                    spies[country][spy] = 0;
                }
                spies[country][spy] = daysInService;

                input = Console.ReadLine();
            }

            foreach (var item in spies.OrderByDescending(s => s.Value.Keys.Count))
            {
                Console.WriteLine("Country: {0}", item.Key);
                foreach (var spy in spies.Values.OrderByDescending(d => d.Values))
                {
                    Console.WriteLine("**{0} : {1}", spy.Keys, spy.Values);
                }
            }
        }
    }
}
