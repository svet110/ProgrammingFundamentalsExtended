using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastThreeConsecutiveEqualStrings
{
    class LastThreeConsecutiveEqualStrings
    {
        static void Main()
        {
            string[] text = Console.ReadLine().Split(' ');                

            for (int i = text.Length-1; i >= 2; i--)
            {
                if (text[i] == text[i-1] && text[i] == text[i-2])
                {
                    Console.WriteLine("{0} {0} {0}", text[i]);
                    break;
                }                
            }
        }
    }
}
