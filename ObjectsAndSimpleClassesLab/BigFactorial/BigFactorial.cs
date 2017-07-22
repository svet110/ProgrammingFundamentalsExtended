﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;


namespace BigFactorial
{
    class BigFactorial
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger result = 1;

            for (int i = n; i >= 1; i--)
            {
                result *= i;
            }

            Console.WriteLine(result);
        }
    }
}
