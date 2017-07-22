using System;
using System.Collections.Generic;
using System.Linq;

namespace Wardrobe
{
    class Wardrobe
    {
        static void Main()
        {
            var wardrobe = new Dictionary<string, Dictionary<string, int>>();
            
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string[] input = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string color = input[0];

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe[color] = new Dictionary<string, int>();
                }

                string[] inputClothes = input[1].Split(',');

                foreach (var clothes in inputClothes)
                {
                    if (!wardrobe[color].ContainsKey(clothes))
                    {
                        wardrobe[color][clothes] = 0;
                    }

                    wardrobe[color][clothes]++;
                }            
            }

            string[] secondInput = Console.ReadLine().Split(' ');

            foreach (var clothes in wardrobe)
            {
                string color = clothes.Key;
                Console.WriteLine("{0} clothes:", color);

                foreach (var garment in clothes.Value)
                {
                    Console.Write("* {0} - {1}", garment.Key, garment.Value);
                    if (color == secondInput[0] && garment.Key == secondInput[1])
                    {
                        Console.Write(" (found!)");
                    }

                    Console.WriteLine();
                }                
            }            
        }
    }
}
