using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7
{
    public class Circle : Geometry
    {
        public double Radius { get; set; }
        public Circle()
        {
            Radius = 4;
        }
        public override double Area()
        {
            return Radius * Radius * Math.PI;
        }
        public override void PrintArea()
        {
            Console.WriteLine($"Area of circle: {Math.Round(Area(),2)}\n");
        }
    }
}