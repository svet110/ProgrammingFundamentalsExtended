using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayData
{
    class ArrayData
    {
        static void Main()
        {
            var list = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            double listAverage = list.Average();

            list = list.Where(n => n >= listAverage).ToList();

            if (command == "Min")
            {
                int min = list.Min();
                Console.WriteLine("{0}", min);
            }
            else if (command == "Max")
            {
                int max = list.Max();
                Console.WriteLine("{0}", max);
            }
            else
            {
                list.Sort();
                Console.WriteLine("{0}", string.Join(" ", list));
            }
        }
    }
}
