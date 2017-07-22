using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectanglePosition
{
    public class Rectangle
    {
        public int Top { get; set; }
        public int Left { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Right
        {
            get
            {
                return Left + Width;
            }            
        }

        public int Bottom 
        { 
            get 
            {
                return Top + Height;
            } 
        }

        public bool IsInside(Rectangle rectangle)
        {
            var leftIsValid = rectangle.Left <= Left;
            var topIsValid = rectangle.Top <= Top;
            var rightIsValid = rectangle.Right >= Right;
            var bottomIsValid = rectangle.Bottom >= Bottom;

            return leftIsValid && topIsValid && rightIsValid && bottomIsValid;
        }   
    }     
    
    public class RectanglePosition
    {
        public static void Main()
        {
            var firstRectangle = ReadRectangle();
            var secondRectangle = ReadRectangle();

            var isInside = firstRectangle.IsInside(secondRectangle);

            Console.WriteLine(isInside ? "Inside" : "Not inside");            
        }           

        public static Rectangle ReadRectangle()
        {
            int[] rectangleParts = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            return new Rectangle
            {
                Top = rectangleParts[0],
                Left = rectangleParts[1],
                Width = rectangleParts[2],
                Height = rectangleParts[3]
            };
        }
    }
}
