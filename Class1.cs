using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba6_Task2
{
    class Class1
    {
        public void Message()
        {
            Console.WriteLine(" got sick");
        }

        public void MessageOne(Pet pet)
        {
            Console.WriteLine(pet.Name + " got sick");
        }
    }
}
