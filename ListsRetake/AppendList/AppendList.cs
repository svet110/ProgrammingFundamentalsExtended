using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendList
{
    public class AppendList
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split('|').ToArray();
            List<string> result = new List<string>();
            
            for (int i = input.Length - 1; i >= 0; i--)
            {
                result.Add(input[i].Trim());
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}