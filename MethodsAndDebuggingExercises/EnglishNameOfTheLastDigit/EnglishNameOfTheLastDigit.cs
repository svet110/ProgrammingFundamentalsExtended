using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishNameOfTheLastDigit
{
    public class EnglishNameOfTheLastDigit
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string nameOfDigit = LastDigitName(n);
            Console.WriteLine(nameOfDigit);
        }

        public static string LastDigitName(int n)
        {
            int lastDigit = n % 10;
            string name = string.Empty;

            switch (lastDigit)
            {
                case 0:
                    name = "zero";
                    break;
                case 1:
                    name = "one";
                    break;
                case 2:
                    name = "two";
                    break;
                case 3:
                    name = "three";
                    break;
                case 4:
                    name = "four";
                    break;
                case 5:
                    name = "five";
                    break;
                case 6:
                    name = "six";
                    break;
                case 7:
                    name = "seven";
                    break;
                case 8:
                    name = "eight";
                    break;
                case 9:
                    name = "nine";
                    break;
            }

            return name;
        }
    }
}
