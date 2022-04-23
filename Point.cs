using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba6_Task1
{
    sealed class Point : GeometricShape // класс закрытый для наследования
    {
        //не переопределяется
        public override double Perimetr()
        {
            return 0;
        }

        public override double Square()
        {
            return 0;
        }
    }
}
