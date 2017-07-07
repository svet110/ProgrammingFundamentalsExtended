using System;
using System.Collections.Generic;
using System.Linq;

namespace DictionariesExercises
{
    class LetterRepetition
    {
        static void Main()
        {
            string input = Console.ReadLine();

            var dict = new Dictionary<char, int>();

            foreach (var letter in input)
            {
                if (!dict.ContainsKey(letter))
                {
                    dict[letter] = 0;
                }

                dict[letter]++;
            }

            foreach (var letter in dict)
            {
                Console.WriteLine("{0} -> {1}", letter.Key, letter.Value);
            }
        }
    }
}
