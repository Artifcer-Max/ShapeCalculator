using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculator
{
    public class Trapezoid : IShape
    {
        //declaration of the base,side and height types
        private double Base1;
        private double Base2;
        private double Side1;
        private double Side2;
        private double Height;

        //setting bases, sides and height to 0
        private Trapezoid()
        {
            Base1 = 0;
            Base2 = 0;
            Side1 = 0;
            Side2 = 0;
            Height = 0;
        }
        //set bases, sides and height to inputted numbers
        public Trapezoid(double base1, double base2, double side1, double side2, double height)
        {
            Base1 = base1;
            Base2 = base2;
            Side1 = side1;
            Side2 = side2;
            Height = height;
        }
        //algorith for determining the Area of the trapezoid
        public double GetArea()
        {
            return (Base1 + Base2) / 2 * Height;
        }
        //Algoritm for determining the perimeter of the trapezoid
        public double GetPerimeter()
        {
            return Base1 + Base2 + Side1 + Side2;
        }

    }
}
