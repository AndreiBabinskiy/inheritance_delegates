using System;

namespace Laba6_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pet petDog = new Pet("Dog_Bobik", 10);
            Console.WriteLine(petDog);
            //petDog.addDelvoid(speakDog);
            petDog.runDelvoid();
            Console.WriteLine("----------------------------");
            petDog.addDelvoid(delegate () { Console.WriteLine(" Gur-Gur"); });//анонимный делегат
            petDog.addDelvoid(() => Console.WriteLine(" BO-BO"));//лямда-выражение
            petDog.Speak();

            Console.WriteLine("----------------------------");
            Pet petKat = new Pet("Kat_Lora", 5);
            Console.WriteLine(petKat);
            //petKat.addDelvoid(speakDog);-групповой делегат
            petKat.addDelvoid(speakKat);
            petKat.runDelvoid();
            Console.WriteLine("----------------------------");
            petKat.Speak();

            Console.WriteLine("----------------------------");
            Console.WriteLine("Delegate Comparison");
            if (petDog.Compare(petKat) == true)
            {
                Console.WriteLine("Delegates are equal");
            }
            else
            {
                Console.WriteLine("Delegates are not equal");
            }

            Class1 class1 = new Class1();
            Class2 class2 = new Class2();

            
            petDog.ReactionOnFeed += class1.Message;//на первого питомца подписан первый класс 
            petKat.ReactionOnFeed += class2.Message;
            
            petKat.ReactionOnFeed += () => Console.WriteLine(petKat.Name + " tired ");//лямда
            //Console.WriteLine("-----------------------");
            petKat.Reaction_On_Feed += Feed100;
            petDog.Reaction_On_Feed += class1.MessageOne;//экземплярный
            petKat.Reaction_On_Feed += class2.MessageOne;
            petKat.Reaction_On_Feed += class2.MessageOne;
            petDog.Reaction_On_Feed += (petDog) => Console.WriteLine(petDog.Name + " tired");//лямда 

            Console.WriteLine("----------------------------");
            petDog.addDelparam(FeedDog);
            Console.WriteLine(petDog);
            petDog.Feed(10);
            Console.WriteLine(petDog);
            petKat.addDelparam(FeedKat);
            Console.WriteLine(petKat);
            petKat.Feed(200);
            Console.WriteLine(petKat);
            Console.WriteLine("------------------------------");
            petKat.addDelPARAM(fdKat => fdKat * 10);//лямда
            Console.WriteLine(petKat);

        }
        public static void Feed100(Pet pet) {
            Console.WriteLine(pet.Name + " got fat " + pet.Weight);
        }
        public static void speakKat()
        {
            Console.WriteLine(" Meow-Meow ");
        }

        public static void speakDog()
        {
            Console.WriteLine(" Gav-Gav ");
        }

        public static double FeedKat (double fdKat)
        {
            return fdKat * 0.1;
        }

        public static double FeedDog (double fdDog)
        {
            return fdDog;
        }
    }
}
