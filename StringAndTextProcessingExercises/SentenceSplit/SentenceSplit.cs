using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentenceSplit
{
    class SentenceSplit
    {
        static void Main()
        {
            string sentence = Console.ReadLine();
            string delimiter = Console.ReadLine();

            sentence = sentence.Replace(delimiter, "delimiter");

            string[] elements = sentence
                .Split(new string[] { "delimiter" }, StringSplitOptions.None);

            Console.WriteLine("[" + string.Join(", ", elements) + "]");            
        }
    }
}
