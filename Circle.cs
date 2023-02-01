using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculator
{
    public class Circle : IShape
    {
        //declaration of the Radius type
        private double Radius;

        //Set Radius to 0
        private Circle()
        {
            Radius = 0;
        }

        //set Radius to input number
        public Circle(double radius)
        {
            Radius = radius;
        }
        //Algoritm to get the Area of the circle
        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
        //Algoritm to get the Perimeter of the circle
        public double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
