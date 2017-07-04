using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionariesLab
{
    class OddOccurences
    {
        static void Main()
        {
            var words = new Dictionary<string, int>();
            string[] input = Console.ReadLine().ToLower().Split();

            for (int i = 0; i < input.Length; i++)
            {
                if (!words.ContainsKey(input[i]))
                {
                    words.Add(input[i], 0);
                }

                words[input[i]]++;
            }

            var result = new List<string>();

            foreach (var word in words)
            {
                if (word.Value % 2 == 1)
                {
                    result.Add(word.Key);
                }
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
