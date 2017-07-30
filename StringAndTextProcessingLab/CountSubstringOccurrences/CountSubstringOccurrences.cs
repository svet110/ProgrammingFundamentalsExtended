using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSubstringOccurrences
{
    public class CountSubstringOccurrences
    {
        public static void Main()
        {
            string input = Console.ReadLine().ToLower();
            string part = Console.ReadLine().ToLower();
            int counter = 0;
            int index = -1;

            while (true)
            {
                index = input.IndexOf(part, index + 1);
                if (index < 0)
                {
                    break;
                }

                counter++;
            }

            Console.WriteLine(counter);
        }
    }
}
