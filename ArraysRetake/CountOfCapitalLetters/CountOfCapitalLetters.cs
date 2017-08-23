using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOfCapitalLetters
{
    class CountOfCapitalLetters
    {
        static void Main()
        {
            string[] text = Console.ReadLine().Split(' ');
            int counter = 0;
            for (int i = 0; i < text.Length; i++)
            {
                string element = text[i];
                if (element[0] >= 'A' && element[0] <= 'Z')
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
