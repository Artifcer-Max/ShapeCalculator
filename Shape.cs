using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculator
{
    public interface IShape
    {
        //base method for Area
        public abstract double GetArea();
        //base method for perimeter
        public abstract double GetPerimeter();
    }
}
