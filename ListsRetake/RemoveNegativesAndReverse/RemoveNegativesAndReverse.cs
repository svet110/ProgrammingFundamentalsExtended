using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveNegativesAndReverse
{
    class RemoveNegativesAndReverse
    {
        static void Main()
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var reversed = new List<int>();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] >= 0)
                {
                    reversed.Add(list[i]);
                }
            }
            
            if (reversed.Count > 0)
            {
                reversed.Reverse();
                Console.WriteLine(string.Join(" ", reversed));
            }
            else
            {
                Console.WriteLine("empty");
            }            
        }
    }
}
