using System;
using System.Collections.Generic;
using System.Linq;

namespace RecordUniqueNames
{
    class RecordUniqueNames
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var set = new HashSet<string>();

            for (int i = 1; i <= n; i++)
            {
                string name = Console.ReadLine();
                set.Add(name);
            }

            Console.WriteLine(string.Join(Environment.NewLine, set));
        }
    }
}
