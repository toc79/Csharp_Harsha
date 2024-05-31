using System;
using System.Collections.Generic;

namespace DateTimeExample
{
	public class Person
	{
		public string PersonName { get; set; }
		public DateTime DateOfBirdh { get; set; }
	}

	internal class Program
	{
		static void Main()
		{
			Person person1 = new Person();
			person1.PersonName = "Miller";
			person1.DateOfBirdh = DateTime.Parse("2000-12-31 11:59:59.999 AM");
			person1.DateOfBirdh = Convert.ToDateTime("2000-12-31 11:59:59.999 AM");

			Console.WriteLine("person1: " + person1.PersonName + ", " + person1.DateOfBirdh.ToString());
			Console.WriteLine("Day: " + person1.DateOfBirdh.Day);
			Console.WriteLine("Day of week: " + person1.DateOfBirdh.DayOfWeek);
			Console.WriteLine("Day of week: " + (int)person1.DateOfBirdh.DayOfWeek);

			DateTime dt = DateTime.Now;
			Console.WriteLine(dt.ToString());

			Console.ReadKey();
		}
	}
}
