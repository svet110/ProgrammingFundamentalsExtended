using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOddNumbers
{
    public class CountOddNumbers
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine(OddCount(numbers));
        }

        public static int OddCount(int[] numbers)
        {
            int counter = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    counter++;
                }                
            }
            return counter;
        }
    }
}
