using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAnArrayOfIntegers
{
    class ReverseAnArrayOfIntegers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = n-1; i >= 0; i--)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                numbers[i] = currentNumber;
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
