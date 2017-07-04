using System;
using System.Collections.Generic;
using System.Linq;

namespace DictionariesLab
{
    class CountRealNumbers
    {
        static void Main()
        {
            var numbers = new SortedDictionary<double, int>();
            double[] input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                if (!numbers.ContainsKey(input[i]))
                {
                    numbers.Add(input[i], 0);
                }

                numbers[input[i]]++;
            }

            foreach (var number in numbers.Keys)
            {
                Console.WriteLine("{0} -> {1} times", number, numbers[number]);
            }
        }
    }
}
