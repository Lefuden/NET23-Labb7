using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7
{
    public class Rectangle : Geometry
    {
        //unsure if this was the intention in the instructions, having to create same/similar properties in several places.
        public double Width { get; set; }
        public double Height { get; set; }
        public Rectangle(double height)
        {
            Width = 4;
            Height = height;
        }
        //not a great way to implement the calculation as it overwrites the data in Height,
        //which will result in misscalculations if data has to be reused.
        public override double Area()
        {
            return Height *= Width;
        }
        //using Height for the output as Area() overwrites the value in it
        public override void PrintArea()
        {
            Console.WriteLine($"Area of rectangle: {Math.Round(Height, 2)}\n");
        }
    }
}