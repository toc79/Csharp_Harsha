using System;
using System.Collections.Generic;

namespace CovarianceExample
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

    interface IMover<out T>//out keywords is for converiance
    {
        T Move();//only as return type and can not be argument/parametar type eg. Method1(T x)
    }

    class Mover<T> : IMover<T> 
    {
        public T thing {  get; set; }
        public T Move()
        {
            return thing;
        }
    }

    class Sample
    {
        public void PrintValues(IEnumerable<object> values)
        {
            foreach (var item in values) { 
                Console.Write(item +", ");
            }
            Console.WriteLine();
        }
    }
    
    class Program
    {
        static void Main()
        {
            //create object
            LivingThing livingThing = new Parrot(); //not covariance
            Parrot parraot = new Parrot() { NumberOfLegs = 2} ;//normal

            //Covariance = suplly the child type name, where the parent type name is expected.
            IMover<LivingThing> mover = new Mover<Parrot>() { thing = parraot};//"LivingThing" vs "Parrot"; supplying the child type (Parrot), where the parent type (LivingtThing) is expected

            Console.WriteLine("Moving with " +mover.Move().NumberOfLegs +" legs.");


            Sample sample = new Sample();
            sample.PrintValues(new List<string> { "hello", "world" });

            Console.ReadKey();
            
        }
    }
}
