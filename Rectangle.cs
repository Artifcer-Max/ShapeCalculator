using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculator
{
    public class Rectangle : IShape
    {
        //declaration of the length and height type
        public double Length;
        public double Height;
        //setting length and height to 0
        public Rectangle()
        {
            Length = 0;
            Height = 0;
        }
        //setting length and height to inputted numbers
        public Rectangle(double length, double height)
        {
            Length = length;
            Height = height;
        }
        //algoritm for determining the area of a rectangle
        public double GetArea()
        {
            return Length * Height;
        }
        //alogithm for determining the perimeter of a rectangle
        public double GetPerimeter()
        {
            return 2 * (Length + Height);
        }
    }
}
