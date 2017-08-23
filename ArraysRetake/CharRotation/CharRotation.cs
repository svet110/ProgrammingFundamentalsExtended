using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharRotation
{
    class CharRotation
    {
        static void Main()
        {
            var text = Console.ReadLine().ToCharArray();
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string result = string.Empty;
            
            for (int i = 0; i < text.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    text[i] = (char)((int)text[i] - arr[i]);
                }
                else
                {
                    text[i] = (char)((int)text[i] + arr[i]);
                }
            }

            Console.WriteLine(string.Join("", text));
        }
    }
}
