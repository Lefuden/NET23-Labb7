using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7
{
    public class Parallelogram : Geometry
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public Parallelogram(double width)
        {
            Height = 7.4;
            Width = width;
        }
        //alternative way of handling the data compared to the method in rectangle. doesn't overwrite data in Height.
        //an alternative would be to add another variable to store the calculation in.
        public override double Area()
        {
            return Height * Width;
        }
        //following the logic above, call the method Area inside PrintArea to avoid overwriting Height.
        public override void PrintArea()
        {
            Console.WriteLine($"Area of parallellogram: {Math.Round(Area(), 2)}\n");
        }
    }
}
