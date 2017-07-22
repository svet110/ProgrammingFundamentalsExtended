using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceBetweenPoints
{
    class DistanceBetweenPoints
    {
        static void Main()
        {
            var firstPoint = ReadPoint();
            var secondPoint = ReadPoint();

            var result = Distance(firstPoint, secondPoint);
            Console.WriteLine("{0:f3}", result);
        }

        public static Point ReadPoint()
        {
            int[] pointParts = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            return new Point
            {
                X = pointParts[0],
                Y = pointParts[1]
            };
        }

        public static double Distance(Point first, Point second)
        {
            var squareX = Math.Pow((first.X - second.X), 2);
            var squareY = Math.Pow((first.Y - second.Y), 2);

            var result = Math.Sqrt(squareX + squareY);

            return result;
        }
    }
}
