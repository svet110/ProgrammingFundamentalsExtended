using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Phonebook
    {
        static void Main()
        {
            string[] phones = Console.ReadLine().Split(' ');
            string[] names = Console.ReadLine().Split(' ');
            
            string lines = Console.ReadLine();
            while (lines != "done")
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (lines == names[i])
                    {
                        Console.WriteLine("{0} -> {1}", names[i], phones[i]);
                        break;
                    }
                }
                
                lines = Console.ReadLine();
            }
        }
    }
}
