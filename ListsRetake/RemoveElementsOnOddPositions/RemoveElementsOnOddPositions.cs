using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveElementsOnOddPositions
{
    class RemoveElementsOnOddPositions
    {
        static void Main()
        {
            var text = Console.ReadLine().Split(' ').ToList();
            var output = new List<string>();

            for (int i = 0; i < text.Count; i++)
            {
                if (i % 2 != 0)
                {
                    output.Add(text[i]);
                }
            }

            Console.WriteLine(string.Join("", output));
        }
    }
}
