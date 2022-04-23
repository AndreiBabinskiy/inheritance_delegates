using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba6_Task1
{
    class Rectangle : GeometricShape
    {
        private double width;

        private double height;

        public Rectangle() // : base()
        {
            Width = 10;
            Height = 5;
        }

        public Rectangle(double x, double y, double width, double height) : base(x, y)
        {
            Width = width;
            Height = height;
        }

        public double Width { get => width; set => width = value; }
        public double Height { get => height; set => height = value; }



        public override double Perimetr()
        {
            double p = (Width + Height) * 2;
            return p;
        }

        //переопределяется
        public override void Print()
        {
            Console.WriteLine("Rectangle at the point: " + "x = " + X + " y = " + Y + 
                " dimensions " + " width = " + Width + " height = " + Height);
        }

        public override double Square()
        {
            double s = Height * Width;
            return s;
        }
    }
}
