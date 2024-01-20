using System;
using ClassLibrary1;

namespace AnonymusObjectExample
{
	internal class Program
	{
		static void Main()
		{
			//create object of Person class
			Person p = new Person();

			//call Methods
			var person = new { PersonName = p.GetPersonName(), Age = p.GetPersonAge(), Adress = new {Street = "abc", City = "xyz" } };

			//print
			Console.WriteLine(person.PersonName);
			Console.WriteLine(person.Age);
			Console.WriteLine(person.Adress.Street);
			Console.WriteLine(person.Adress.City);
			Console.ReadKey();
		}
	}
}
