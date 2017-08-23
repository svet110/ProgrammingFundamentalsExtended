using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayEqualToIndex
{
    class ArrayEqualToIndex
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == i)
                {
                    Console.Write("{0} ", numbers[i]);
                }                
            }
        }
    }
}
