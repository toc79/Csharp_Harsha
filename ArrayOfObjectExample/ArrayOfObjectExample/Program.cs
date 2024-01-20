using System;
using ClassLibrary1;

namespace ArrayOfObjectExample
{
	internal class Program
	{
		static void Main()
		{
			//create object of Employee class
			//Employee emp1 = new Employee() {EmpID = 101, EmpName="Scott" };
			//Employee emp2 = new Employee() {EmpID = 102, EmpName="Smith" };
			//Employee emp3 = new Employee() {EmpID = 103, EmpName="John" };

			//create array of objects
			//Employee[] employees = new Employee[] { emp1, emp2, emp3 };
			Employee[] employees = new Employee[] {
				new Employee() { EmpID = 101, EmpName = "Scott" },
				new Employee() { EmpID = 102, EmpName = "Smith" },
				new Employee() { EmpID = 103, EmpName = "John" }
			};

			//foreach loop for array of objects
			foreach(Employee item in employees)
			{
				if(item.EmpID>=102)
				Console.WriteLine(item.EmpID +", " +item.EmpName);
			}

			Console.ReadKey();
		}
	}
}
