using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitWordCasing
{
    class SplitWordCasing
    {
        static void Main()
        {
            string[] text = Console.ReadLine().Split(new char[] 
            { '.', ',', ';', ':', '!', '(', ')', '"', '\'', '\\', '/', '[', ']' }
            ,StringSplitOptions.RemoveEmptyEntries);

            var lowercase = new List<string>();
            var uppercase = new List<string>();
            var mixed = new List<string>();

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].All(char.IsUpper))
                {
                    uppercase.Add(text[i]);
                }
                else if (text[i].All(char.IsLower))
                {
                    lowercase.Add(text[i]);
                }
                else
                {
                    mixed.Add(text[i]);
                }
            }

            Console.WriteLine("Lower-case: {0}", string.Join(", ", lowercase));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixed));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", uppercase));
        }
    }
}