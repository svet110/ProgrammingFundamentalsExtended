using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClosestTwoPoints
{
    class ClosestTwoPoints
    {
        public class Point
        {
            public double X { get; set; }
            public double Y { get; set; }
        }     
        
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var points = new List<Point>();

            for (int i = 0; i < n; i++)
            {
                var currentPoint = ReadPoint();
                points.Add(currentPoint);
            }

            var minDistance = double.MaxValue;
            Point firstPointResult = null;
            Point secondPointResult = null;

            for (int first = 0; first < points.Count; first++)
            {
                for (int second = first + 1; second < points.Count; second++)
                {
                    var firstPoint = points[first];
                    var secondPoint = points[second];

                    var distance = Distance(firstPoint, secondPoint);

                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        firstPointResult = firstPoint;
                        secondPointResult = secondPoint;
                    }
                }                
            }

            Console.WriteLine("{0:f3}", minDistance);
            Console.WriteLine("({0}, {1})", firstPointResult.X, firstPointResult.Y);
            Console.WriteLine("({0}, {1})", secondPointResult.X, secondPointResult.Y);
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
