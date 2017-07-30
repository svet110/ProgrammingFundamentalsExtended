using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    public class Palindromes
    {
        public static void Main()
        {
            List<string> inputWords = Console.ReadLine()
                .Split(",!?. ".ToCharArray()
                ,StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> result = new List<string>();

            foreach (var word in inputWords)
            {
                string reversedWord = ReverseWord(word);
                if(reversedWord == word && !result.Contains(word))
                {
                    result.Add(reversedWord);
                }
            }
            
            result = result.OrderBy(w => w).ToList();

            Console.WriteLine(string.Join(", ", result));
        }

        static string ReverseWord(string word)
        {
            char[] reverse = word.ToCharArray();
            Array.Reverse(reverse);

            return(new string(reverse));
        }
    }
}

