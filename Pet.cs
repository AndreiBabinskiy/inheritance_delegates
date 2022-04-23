using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba6_Task2
{
    delegate void DELVOID();
    delegate double DELPARAM(double wgt);

    class Pet
    {
        private string name;
        private double weight;

        private DELVOID delvoid;
        private DELPARAM delparam;
        private Action delVOID; //универсальные делегаты
        private Func<double, double> delPARAM;// последний аргумент, что возвращается
        public event Action reaction_OnFeed;
        public event Action<Pet> reaction_On_Feed;

        public Pet(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }

        public string Name { get => name; set => name = value; }
        public double Weight { get => weight; set => weight = value; }

        public event Action ReactionOnFeed //акссесоры
        {
            add
            {
                reaction_OnFeed += value;
            }

            remove
            {
                reaction_OnFeed -= value;
            }            
        }

        public event Action<Pet> Reaction_On_Feed //акссесоры
        {
            add
            {
                reaction_On_Feed += value;
            }

            remove
            {
                reaction_On_Feed -= value;
            }
        }

        public void addDelVOID(Action del)
        {
            delVOID += del;
        }

        public void addDelvoid(DELVOID del)
        {
            delvoid += del;
        }

        public void addDelparam(DELPARAM par)
        {
            delparam += par;
        }

        public void addDelPARAM(Func<double, double> par)
        {
            delPARAM += par;
        }

        public void runDelvoid()
        {
            delvoid?.Invoke();

            /*if(delvoid != null)
            {
               
            }*/
        }

        public void Speak()
        {
            Console.Write("Name " + Name + " Speak ");
            runDelvoid();
        }

        public void Feed(double meal)
        {
            if(delparam != null)
            {
                Weight += delparam(meal);
            }

            if(Weight > 5)
            {
                Console.Write(Name + " ");
                reaction_OnFeed?.Invoke();
            }

            if (Weight > 4)
            {
                Console.Write(Name + " ");
                reaction_On_Feed?.Invoke(this);
            }
        }



        public bool Compare(Pet pet)
        {
            return delvoid == pet.delvoid;
        }
        public override string ToString()
        {
            return "Name " + Name + " Weight " + Weight + " kg";
        }
    }
}
