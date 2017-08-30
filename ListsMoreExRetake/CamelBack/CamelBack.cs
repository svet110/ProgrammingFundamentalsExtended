using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamelBack
{
    class CamelBack
    {
        static void Main()
        {
            var buildings = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int camelBackSize = int.Parse(Console.ReadLine());
            int rounds = 0;

            if (buildings.Count > camelBackSize)
            {
                while (buildings.Count > camelBackSize)
                {
                    buildings.RemoveAt(0);
                    buildings.RemoveAt(buildings.Count - 1);
                    rounds++;
                }

                Console.WriteLine("{0} rounds", rounds);
                Console.WriteLine("remaining: {0}", string.Join(" ", buildings));
            }
            else
            {
                Console.WriteLine("already stable: {0}", string.Join(" ", buildings));
            }           
        }
    }
}
