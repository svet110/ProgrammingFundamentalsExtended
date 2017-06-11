using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathPower
{
    class MathPower
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = int.Parse(Console.ReadLine());
            Console.WriteLine(RaiseToPower(a, b));
        }

        static double RaiseToPower(double num, double power)
        {
            double result = Math.Pow(num, power);
            return result;
        }
    }
}
