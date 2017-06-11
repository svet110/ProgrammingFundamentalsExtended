using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterOfTwoValues
{
    class GreaterOfTwoValues
    {
        static void Main()
        {
            string type = Console.ReadLine();
            if (type == "string")
            {
                string a = Console.ReadLine();
                string b = Console.ReadLine();
                Console.WriteLine(GetMax(a, b));
            }
            else if (type == "int")
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(num1, num2));
            }
            else if (type == "char")
            {
                char char1 = char.Parse(Console.ReadLine());
                char char2 = char.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(char1, char2));
            }


        }

        static string GetMax(string a, string b)
        {
            if (a.CompareTo(b) >= 0)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        static int GetMax(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else 
            {
                return b;
            }
        }

        static char GetMax(char a, char b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}
