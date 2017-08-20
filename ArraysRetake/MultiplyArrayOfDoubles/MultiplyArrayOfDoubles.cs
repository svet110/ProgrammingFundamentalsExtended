using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyArrayOfDoubles
{
    public class MultiplyArrayOfDoubles
    {
        public static void Main()
        {
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] *= n;
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
