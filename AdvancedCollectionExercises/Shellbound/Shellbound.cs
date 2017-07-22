using System;
using System.Collections.Generic;
using System.Linq;

namespace Shellbound
{
    class Shellbound
    {
        static void Main()
        {
            var shellbound = new Dictionary<string, List<int>>();
            var input = Console.ReadLine().Split(' ');
            
            while (input[0] != "Aggregate")
            {
                string region = input[0];
                var size = int.Parse(input[1]);

                if (!shellbound.ContainsKey(region))
                {
                    shellbound[region] = new List<int>();
                }
                if (!shellbound[region].Contains(size))
                {
                    shellbound[region].Add(size);
                }

                input = Console.ReadLine().Split(' ');
            }

            foreach (var shell in shellbound)
            {
                string key = shell.Key;
                var sizes = shell.Value;
                int sum = sizes.Sum();

               int giantShell = sum - (int)sizes.Average();
               
                Console.WriteLine("{0} -> {1} (2)", key, string.Join(", ", sizes), giantShell);
            }
        }
    }
}
