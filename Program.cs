using System;

namespace Laba6_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(5, 8, 20, 10);
            rectangle.Print();
            Console.WriteLine("Rectangle Perimetr = " + rectangle.Perimetr());
            Console.WriteLine("Rectangle Square = " + rectangle.Square());
            Rectangle rectangle1 = new Rectangle();
            rectangle1.Print();
            Console.WriteLine("Rectangle 1 Perimetr = " + rectangle1.Perimetr());
            Console.WriteLine("Rectangle 1 Square = " + rectangle1.Square());

            GeometricShape circle = new Circle(60, 10, 15);
            circle.Print();
            Console.WriteLine("Circle Perimetr = " + circle.Perimetr());
            Console.WriteLine("Circle Square = " + circle.Square());
            Circle circle1 = new Circle();
            circle1.Print();
            Console.WriteLine("Circle1 Perimetr = " + circle1.Perimetr());
            Console.WriteLine("Circle1 Square = " + circle1.Square());

            Point point = new Point();
            point.Print();
            Console.WriteLine("Point Perimetr = " + point.Perimetr());
            Console.WriteLine("Point Square = " + point.Square());
        }
    }
}
