using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareNumber
{
    class SquareNumber
    {
        static void Main()
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var result = new List<int>();
            list.Sort();
            list.Reverse();

            for (int i = 0; i < list.Count; i++)
            {
                if (Math.Sqrt(list[i]) == (int)(Math.Sqrt(list[i])))
                {
                    result.Add(list[i]);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
