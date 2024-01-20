//using System;
using static System.Console;
class Program
{
	static void Main()
	{
		//reference variable
		//Person p;
		//System.Object abc = new Person();

		//p = new Supplier();

		//int a = 10;

		//int b = new int();
		//int? c = null;

		//WriteLine(a);
		//WriteLine(b);
		//WriteLine(c);

		//create an object of Person class
		System.Object obj = new Person() {PersonName = "Scott", Email = "scott@gmailcom" };

		//access methods
		WriteLine(obj.Equals(new Person() { PersonName = "Scott", Email = "scott@gmailcom" } ));
		WriteLine(obj.GetHashCode());
		WriteLine(obj.ToString());
		WriteLine(obj.GetType().ToString());

		ReadKey();	}
}