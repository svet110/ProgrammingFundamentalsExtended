using System;
using System.Collections.Generic;
using System.Linq;

namespace Key_Value
{
    class KeyValue
    {
        static void Main()
        {
            string searchedKey = Console.ReadLine();
            string searchedValue = Console.ReadLine();
            var keyValueDB = new Dictionary<string, List<string>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(new string[] { " => " }, StringSplitOptions.RemoveEmptyEntries);
                var values = tokens[1].Split(';').ToList();
                if (tokens[0].Contains(searchedKey))
                {
                    keyValueDB.Add(tokens[0], new List<string>());
                    for (int q = 0; q < values.Count; q++)
                    {
                        if (values[q].Contains(searchedValue))
                        {
                            keyValueDB[tokens[0]].Add(values[q]);
                        }
                    }
                }
            }
            
            foreach (var item in keyValueDB)
            {
                Console.WriteLine(item.Key + ":");
                foreach (var value in item.Value)
                {
                    Console.WriteLine("-{0}", value);
                } 
            }
        }
    }
}

