using System;
using System.Collections.Generic;

namespace ContravarianceExample
{
    class LivingThing
    {
        public int NumberOfLegs { get; set; }
    }

    class Parrot : LivingThing
    {

    }
    class Dog : LivingThing
    {

    }

    interface IMover<in T>
    {
        void Move(T x);
    }

    public class Mover<T> : IMover<T>
    {
        public void Move(T x) {
            if (x is Parrot)
            {
                Console.WriteLine("Moveing with " + (x as Parrot).NumberOfLegs + " legs");
            } else
            {
                Console.WriteLine("Moveing with " + (x as Dog).NumberOfLegs + " legs");
            }
            
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //create normal object
            Parrot parrot = new Parrot() { NumberOfLegs = 2};
            Dog dog = new Dog() { NumberOfLegs = 4};

            IMover <Parrot> obj1 = new Mover<Parrot>(); //normal
            
            //Contravariance = supply the parent type name, where the child type is expected
            IMover <Parrot> obj2 = new Mover<LivingThing>(); 
            // "Parrot" vs "LivingThing"; supplying the parent type (LivingThing), where the child type (Parrot) is expected.

            obj2.Move(parrot);

            IMover<Dog> obj3 = new Mover<LivingThing>();
            obj3.Move(dog);

            Console.ReadKey();

        }
    }
}
