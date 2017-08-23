using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackDownloader
{
    class TrackDownloader
    {
        static void Main()
        {
            var blacklistedWords = Console.ReadLine().Split(' ').ToList();
            var list = new List<string>();
            string names = Console.ReadLine();
            bool isBanned = false;

            while (names != "end")
            {
                for (int i = 0; i < blacklistedWords.Count; i++)
                {
                    if (names.Contains(blacklistedWords[i]))
                    {
                        isBanned = true;
                    }
                    else
                    {
                        continue;
                    }
                }

                if (!isBanned)
                {
                    list.Add(names);
                }

                isBanned = false;
                
                names = Console.ReadLine();
            }

            list.Sort();

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
