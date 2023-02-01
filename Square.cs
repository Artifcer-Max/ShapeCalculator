using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculator
{
    public class Square : Rectangle
    {
        //setting length and height to be the inputed side number
        public Square(double side)
        {
            Length = side;
            Height = side;
        }

    }
}
