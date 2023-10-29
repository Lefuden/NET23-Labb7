using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7
{
    public class Ellipse : Geometry
    {
        public double MajorAxis { get; set; }
        public double MinorAxis { get; set; }

        public Ellipse(double majorAxis)
        {
            MajorAxis = majorAxis;
            MinorAxis = 4.1;
        }
        public override double Area()
        {
            return MajorAxis * MinorAxis * Math.PI;
        }

        public override void PrintArea()
        {
            Console.WriteLine($"Area of ellipse: {Math.Round(Area(), 2)}\n");
        }
    }
}
