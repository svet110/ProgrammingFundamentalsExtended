using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistinctList
{
    class DistinctList
    {
        static void Main()
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var distinctList = list.Distinct();
            
            Console.WriteLine(string.Join(" ", distinctList));
        }
    }
}
