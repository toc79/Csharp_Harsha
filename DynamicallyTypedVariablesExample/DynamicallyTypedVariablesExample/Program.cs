using System;


namespace DynamicallyTypedVariablesExample
{
	class Student
	{
		public string StudentName {get; set;}
	}
	
	class Program
	{
		static void Main()
		{
			//dynamically typed variables
			dynamic x;
			x = 100;
			x = "Hello";
			//x = new Student();
			x = new Student() { StudentName = "Toc" };

			Console.WriteLine(x.StudentName as String);
			Console.ReadKey();
		}
	}
}
