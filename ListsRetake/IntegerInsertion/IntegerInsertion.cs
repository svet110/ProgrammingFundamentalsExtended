using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerInsertion
{
    class IntegerInsertion
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string numAsString = Console.ReadLine();
            int num = 0;

            while (numAsString != "end")
            {
                num = ((int)(numAsString[0] - 48));
                list.Insert(num, int.Parse(numAsString));
                                       
                numAsString = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
