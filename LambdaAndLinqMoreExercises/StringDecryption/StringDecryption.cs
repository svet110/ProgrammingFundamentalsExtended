using System;
using System.Collections.Generic;
using System.Linq;

namespace StringDecryption
{
    class StringDecryption
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int numbersToSkip = arr[0];
            int numbersToTake = arr[1];
            int[] arrayOfIntegers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            arrayOfIntegers = arrayOfIntegers
                .Where(n => n >= 65 && n <= 90)
                .Skip(numbersToSkip)
                .Take(numbersToTake)
                .ToArray();

            foreach (var integer in arrayOfIntegers)
            {
                Console.Write((char)integer);
            }

            Console.WriteLine();
        }
    }
}
