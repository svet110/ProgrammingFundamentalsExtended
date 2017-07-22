using System;
using System.Collections.Generic;
using System.Linq;

namespace Camping
{
    class Camping
    {
        static void Main()
        {
            var campers = new Dictionary<string, List<string>>();
            var nights = new Dictionary<string, int>();
            string customerData = Console.ReadLine();

            while (customerData != "end")
            {
                string[] input = customerData.Split(' ');
                string personName = input[0];
                string camperModel = input[1];
                int nightsToStay = int.Parse(input[2]);

                if (!campers.ContainsKey(personName))
                {
                    campers.Add(personName, new List<string>());
                }

                campers[personName].Add(camperModel);

                if (!nights.ContainsKey(personName))
                {
                    nights.Add(personName, 0);
                }

                nights[personName] += nightsToStay;

                customerData = Console.ReadLine();
            }

            var ordered = campers
                .OrderByDescending(c => c.Value.Count)
                .ThenBy(n => n.Key.Length)
                .ToDictionary(n => n.Key, c => c.Value);

            foreach (var item in ordered)
            {
                string name = item.Key;
                List<string> campersData = item.Value;

                Console.WriteLine("{0}: {1}", name, campersData.Count);

                foreach (var camper in campersData)
                {
                    Console.WriteLine("***{0}", camper);
                }

                Console.WriteLine("Total stay: {0} nights", nights[name]);
            }
        }
    }
}
