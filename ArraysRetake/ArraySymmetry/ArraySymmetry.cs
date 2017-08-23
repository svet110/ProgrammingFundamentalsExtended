using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySymmetry
{
    class ArraySymmetry
    {
        static void Main()
        {
            string[] arr = Console.ReadLine().Split(' ');
            string[] reversed = new string[arr.Length];
            bool isSymmetric = false;
            int index = 0;

            for (int i = reversed.Length-1; i >= 0; i--)
            {
                reversed[i] = arr[index];
                index++;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == reversed[i])
                {
                    isSymmetric = true;
                }
                else
                {
                    isSymmetric = false;
                    break;
                }
            }
            
            if (isSymmetric)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");    
            }            
        }
    }
}
