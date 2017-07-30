using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheLetter
{
    class FindTheLetter
    {
        static void Main()
        {
            string sentence = Console.ReadLine();
            string[] elements = Console.ReadLine().Split();

            char letter = char.Parse(elements[0]);
            int occurence = int.Parse(elements[1]);
            int index = -1;

            for (int i = 0; i < occurence; i++)
            {
                if (index > sentence.Length)
                {
                    break;
                }
                index += 1;
                index = sentence.IndexOf(letter, index);
            }

            if (index == -1)
            {
                Console.WriteLine("Find the letter yourself!");
            }
            else
            {
                Console.WriteLine(index);
            }
        }
    }
}
