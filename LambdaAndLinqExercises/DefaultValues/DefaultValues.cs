using System;
using System.Collections.Generic;
using System.Linq;

namespace DefaultValues
{
    class DefaultValues
    {
        static void Main()
        {
            var pairs = new Dictionary<string, string>();
            var replacedValues = new Dictionary<string, string>();
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] inputLine = input.Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                string key = inputLine[0];
                string value = inputLine[1];

                pairs[key] = value;    
                
                input = Console.ReadLine();
            }

            string defaultValue = Console.ReadLine();

            Dictionary<string, string> unchangedValues = pairs
                .Where(p => p.Value != "null")
                .OrderByDescending(p => p.Value.Length)
                .ToDictionary(p => p.Key, p => p.Value);

            Dictionary<string, string> changedValues = pairs
                .Where(p => p.Value == "null")
                .ToDictionary(p => p.Key, p => p.Value);

            foreach (var unchangedValue in unchangedValues)
            {
                Console.WriteLine("{0} <-> {1}", unchangedValue.Key, unchangedValue.Value);
            }

            foreach (var changedValue in changedValues)
            {
                Console.WriteLine("{0} <-> {1}", changedValue.Key, defaultValue);
            }
        }
    }
}
