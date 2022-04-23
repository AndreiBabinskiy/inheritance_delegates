using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba6_Task1
{
    /*
        * Базовый класс для вашей иерархии объявите абстрактным.
        * Он должен содержать абстрактные методы и методы с реализацией.
     */

    abstract class GeometricShape
    {
        private double x;
        private double y;

        protected GeometricShape(double x, double y)
        {
            X = x;
            Y = y;
        }

        protected GeometricShape()
        {
        }
        //виртуальный свойство
        public virtual double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }

        //виртуальный метод
        public virtual void Print ()
        {
            Console.WriteLine("Geometric shape at the point: " + " x = " + X + " y = " + Y);
        }

        public abstract double Perimetr();

        public abstract double Square();
    }
}
