using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersInReversedOrder
{
    public class NumbersInReversedOrder
    {
        public static void Main()
        {
            decimal num = decimal.Parse(Console.ReadLine());

            Console.WriteLine(ReversedNum(num));
        }

        public static decimal ReversedNum(decimal num)
        {
            string numToStr = num.ToString();
            string result = string.Empty;

            for (int i = numToStr.Length-1; i >= 0; i--)
            {
                result += numToStr[i];    
            }

            return decimal.Parse(result);
        }
    }
}
