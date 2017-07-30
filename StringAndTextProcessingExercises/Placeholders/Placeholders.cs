using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Placeholders
{
    class Placeholders
    {
        static void Main()
        {
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string sentence = tokens[0];
                string[] placeholders = tokens[1].Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < placeholders.Length; i++)
                {
                    string oldString = "{" + i + "}";
                    sentence = sentence.Replace(oldString, placeholders[i]);
                }

                Console.WriteLine(sentence);
                input = Console.ReadLine();
            }
        }
    }
}
