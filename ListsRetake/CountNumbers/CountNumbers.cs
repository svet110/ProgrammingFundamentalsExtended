using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountNumbers
{
    class CountNumbers
    {
        static void Main()
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int counter = 1;
            list.Sort();
            list.Add(int.MaxValue);

            for (int i = 0; i < list.Count-1; i++)
            {
                int current = list[i];
                int next = list[i + 1];
                if (current == next)
                {
                    counter++;
                }
                else
                {
                    Console.WriteLine("{0} -> {1}", current, counter);
                    counter = 1; 
                }
            }
        }
    }
}
