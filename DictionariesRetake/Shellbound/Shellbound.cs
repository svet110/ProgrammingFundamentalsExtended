using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shellbound
{
    public class Shellbound
    {
        public static void Main()
        {
            var shells = new Dictionary<string, HashSet<int>>();

            string input = Console.ReadLine();

            while (input != "Aggregate")
            {
                string[] tokens = input.Split(' ');
                string region = tokens[0];
                int shellSize = int.Parse(tokens[1]);

                AddShell(shells, region, shellSize);

                input = Console.ReadLine();
            }

            foreach (var shell in shells)
            {
                Console.WriteLine("{0} -> {1} ({2})", 
                    shell.Key, 
                    string.Join(", ", shell.Value), 
                    (int)(Math.Ceiling(shell.Value.Sum() - shell.Value.Average())));
            }
        }

        public static void AddShell(Dictionary<string, HashSet<int>> shells, string region, int shellSize)
        {
            if (!shells.ContainsKey(region))
            {
                shells[region] = new HashSet<int>();
            }
            shells[region].Add(shellSize);
        }
    }
}
