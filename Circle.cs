using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba6_Task1
{
    class Circle : GeometricShape
    {
        private double radius;

        public Circle()
        {
            Radius = 30;
        }

        public Circle(double x, double y, double radius) : base(x, y)
        {
            Radius = radius;
        }

        public override double X
        {
            get
            {
                return base.X;
            }
            set
            {
                if (value > -50 && value < 50)
                {
                    base.X = value;
                }
            }
                
        }

        public double Radius { 
            get
            {
                return radius;
            }
            set
            {
                if (value >= 0)
                {
                    radius = value;
                }
            } 
        }

        public override double Perimetr()
        {
            double p = 2 * Math.PI * Radius;
            return p;
        }
        // Продемонстрировать вызов метода родительского класса при его скрытии.
        public new void Print()
        {
            base.Print();
            Console.WriteLine("Circle at the point = " + " x = " + X + " y = " + Y +
                " dimensions " + " Radius = " + Radius);
        }

        public override double Square()
        {
            double s = Math.PI * Radius * Radius;
            return s;
        }
    }
}
