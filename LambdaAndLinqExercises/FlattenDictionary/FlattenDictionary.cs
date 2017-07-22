using System;
using System.Collections.Generic;
using System.Linq;

namespace FlattenDictionary
{
    class FlattenDictionary
    {
        static void Main()
        {
            var orders =
                new Dictionary<string, Dictionary<string, string>>();
            var flattenedOrders = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] inputLine = input.Split(' ');

                if (inputLine[0] == "flatten")
                {
                    string flattenKey = inputLine[1];

                    foreach (var order in orders)
                    {
                        string key = order.Key;
                        var innerKeys = order.Value;
                        if (key == flattenKey)
                        {
                            foreach (var innerKey in innerKeys)
                            {
                                string flattenedValue = innerKey.Key + innerKey.Value;

                                if (!flattenedOrders.ContainsKey(key))
                                {
                                    flattenedOrders.Add(key, new List<string>());
                                }

                                flattenedOrders[key].Add(flattenedValue);
                            }
                        }
                    }

                    orders[flattenKey] = new Dictionary<string, string>();
                }
                else
                {
                    string key = inputLine[0];
                    string innerKey = inputLine[1];
                    string innerValue = inputLine[2];

                    if (!orders.ContainsKey(key))
                    {
                        orders.Add(key, new Dictionary<string, string>());
                    }

                    if (!orders[key].ContainsKey(innerKey))
                    {
                        orders[key].Add(innerKey, "");
                    }

                    orders[key][innerKey] = innerValue;
                }

                input = Console.ReadLine();
            }

            var ordered = orders
                .OrderByDescending(kvp => kvp.Key.Length);

            foreach (var data in ordered)
            {
                string key = data.Key;
                var innerRecords = data.Value;
                var innerDataOrdered = innerRecords
                    .OrderBy(kvp => kvp.Key.Length);

                Console.WriteLine("{0}", key);

                int orderNumber = 1;
                foreach (var innerRecord in innerDataOrdered)
                {
                    Console.WriteLine("{0}. {1} - {2}",
                        orderNumber,
                        innerRecord.Key,
                        innerRecord.Value);

                    orderNumber++;
                }

                if (flattenedOrders.ContainsKey(key))
                {
                    foreach (var flattenedValue in flattenedOrders[key])
                    {
                        Console.WriteLine("{0}. {1}", orderNumber, flattenedValue);
                        orderNumber++;
                    }
                }
            }
        }
    }
}