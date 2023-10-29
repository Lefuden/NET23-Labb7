//Daniel Frykman .NET23
namespace Labb7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create a bunch of objects.
            Geometry circle = new Circle();
            circle.PrintArea();

            Geometry square = new Square();
            square.PrintArea();

            Geometry rectangle = new Rectangle(3.3);
            //not the optimal way of doing it, more comments inside the class
            rectangle.Area();
            rectangle.PrintArea();

            Geometry parallellogram = new Parallelogram(5.9);
            parallellogram.PrintArea();

            Geometry ellipse = new Ellipse(5);
            ellipse.PrintArea();
        }
    }
}