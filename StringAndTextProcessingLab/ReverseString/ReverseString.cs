﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    public class ReverseString
    {
        public static void Main()
        {
            char[] input = Console.ReadLine().ToCharArray();            

            Console.WriteLine(string.Join("", input.Reverse()));
        }
    }
}
