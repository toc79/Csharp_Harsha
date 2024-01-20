using System;
using static System.Console;

namespace TupleExample
{
	class Sample
	{
		public Tuple<string, int> GetPersonDetails()
		{
			Tuple<string, int> tuple = new Tuple<string, int>("Scott", 20);
			
			return tuple;
		}
	}

	internal class Program
	{		
		static void Main()
		{
			
			Sample s = new Sample();

			Tuple<string, int> person = s.GetPersonDetails();

			//create a new Tuple that stores person name and age
			//Tuple<string, int> person = new Tuple<string, int>("Scott", 20);

			//access value
			WriteLine(person.Item1);
			WriteLine(person.Item2);
			
			WriteLine("\nTest var variable:");


			var personVar = s.GetPersonDetails();

			WriteLine(personVar.Item1);
			WriteLine(personVar.Item2);

			// returns compile error Compiler Error CS1061
			//object personObject = s.GetPersonDetails();
			//WriteLine(personObject.Item1);
			//WriteLine(personObject.Item2);

			ReadKey();

		}
	}
}
