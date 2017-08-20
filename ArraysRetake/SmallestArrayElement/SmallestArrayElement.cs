using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestArrayElement
{
    public class SmallestArrayElement
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine(FindSmallestElement(numbers));
        }

        public static int FindSmallestElement(int[] numbers)
        {
            int min = int.MaxValue;
            for (int i = 0; i < numbers.Length; i++)
			{
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
			}

            return min;
        }
    }
}
