using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spyfer
{
    public class Spyfer
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            while (inputLine.Count > 2)
            {
                for (int i = 1; i < inputLine.Count; i++)
                {
                    if (i == inputLine.Count-1)
                    {
                        Console.WriteLine(string.Join(" ", inputLine));
                        return;
                    }
                    if (inputLine[i] == inputLine[i - 1] + inputLine[i + 1])
                    {
                        inputLine.RemoveAt(i-1);
                        inputLine.RemoveAt(i);
                        i = 1;
                    }
                }
            }            

            Console.WriteLine(string.Join(" ", inputLine));
        }
    }
}
