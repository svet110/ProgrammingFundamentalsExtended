using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SpyGram
{
    public class SpyGram
    {
        public static void Main()
        {
            var pattern = @"(TO:)(\s[A-Z]+;)(MESSAGE:)(\s[a-z]+;)";
            var regex = new Regex(pattern);
            var privateKey = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string message = Console.ReadLine();
            var isMatch = regex.IsMatch(message);
            
            while (message != "END")
            {
                if (isMatch)
                {
                    for (int i = 0; i < message.Length; i++)
                    {
                        char symbol = message[i];
                        
                    }
                }   
            }
        }
    }
}
