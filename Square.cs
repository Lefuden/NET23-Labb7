using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7
{
    public class Square : Geometry
    {
        public double Height { get; set; }
        public Square()
        {
            Height = 10.7;
        }
        public override double Area()
        {
            return Height * Height;
        }

        public override void PrintArea()
        {
            Console.WriteLine($"Area of square: {Math.Round(Area(), 2)}\n");
        }
    }
}
