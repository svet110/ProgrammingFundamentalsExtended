using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestArrayElement
{
    public class LargestArrayElement
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            int max = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }

            Console.WriteLine(max);
        }
    }
}
