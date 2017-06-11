using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FilledSquare
{
    class FilledSquare
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            TopRow(n);
            for (int i = 0; i < n/2; i++)
            {
                MiddleRow(n);    
            }
            BottomRow(n);
        }

        static void TopRow(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }

        static void MiddleRow(int n)
        {
            Console.Write("-");
            for (int i = 1; i < n; i++)
            {
                Console.Write("\\/");
            }
            
            Console.WriteLine("-");
        }
        
        static void BottomRow(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }
    }
}
