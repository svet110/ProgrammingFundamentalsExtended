using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMethod
{
    public class MaxMethod
    {
        public static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMax(a, b, c));
        }

        public static int GetMax(int a, int b, int c)
        {
            int maxNumber = Math.Max(a, b);
            int result = Math.Max(maxNumber, c);

            return result;
        }        
    }
}
