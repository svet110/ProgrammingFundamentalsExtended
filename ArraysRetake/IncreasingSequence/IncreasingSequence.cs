using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncreasingSequence
{
    class IncreasingSequence
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool isIncreasing = false;
            for (int i = 0; i < numbers.Length-1; i++)
            {
                if (numbers[i] < numbers[i+1])
                {
                    isIncreasing = true;
                }
                else
                {
                    isIncreasing = false;
                    break;
                }
            }

            if (isIncreasing)
            {
                Console.WriteLine("Yes");
            }
            else
	        {
                Console.WriteLine("No");
	        }
        }
    }
}
