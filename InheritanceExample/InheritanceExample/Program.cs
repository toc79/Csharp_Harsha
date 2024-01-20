using System.Dynamic;
using System.IO;

class Program
{
	static void Main()
	{
		//crate object of Employee
		//Employee emp1 = new Employee(101, "Scott", "Hyderabad");
		////emp1.EmpID = 101;
		////emp1.EmpName = "Scott";
		////emp1.Location = "Hyderabad";
		//System.Console.WriteLine("Object of Parent class (Employee):");
		//System.Console.WriteLine(emp1.EmpID);
		//System.Console.WriteLine(emp1.EmpName);
		//System.Console.WriteLine(emp1.Location);
		//System.Console.WriteLine();

		//crate object of Manager
		//Manager mgr1 = new Manager(102, "Allen", "New York", "Accounting");

		//create reference variable of parent interface (IEmployee)
		IEmployee emp;
		
		//create object of Manager
		emp = new Manager(102, "Allen", "New York", "Accounting");
		emp.DateOfBirth = System.Convert.ToDateTime("1990-07-15");
		System.Console.WriteLine(emp.GetAge());
		//mgr1.EmpID = 102;
		//mgr1.EmpName = "Allen";
		//mgr1.Location = "New York";
		//mgr1.DepartmentName = "Accounting";
		//System.Console.WriteLine("Object of Child class (Manager):");
		//System.Console.WriteLine(mgr1.EmpID);
		//System.Console.WriteLine(mgr1.EmpName);
		//System.Console.WriteLine(mgr1.Location);
		//System.Console.WriteLine(mgr1.GetTotalSalesOfTheYear());
		//System.Console.WriteLine(mgr1.GetFullDepartmentName());
		//System.Console.WriteLine(mgr1.GetHelthInsurianceAmount());
		System.Console.WriteLine(emp.GetHelthInsurianceAmount());
		System.Console.WriteLine();


		//IPerson
		IPerson person;
		person = new Manager(102, "Allen", "New York", "Accounting");
		person.DateOfBirth = System.Convert.ToDateTime("1990-07-15");
		System.Console.WriteLine(person.GetAge());
		System.Console.WriteLine("");





		//crate object of SalesMan
		//SalesMan salesMan1 = new SalesMan(101, "John", "Washington", "East");
		//salesMan1.EmpID = 101;
		//salesMan1.EmpName = "John";
		//salesMan1.Location = "Washington";
		//salesMan1.Region = "East";
		//System.Console.WriteLine("Object of Child class (SalesMan):");
		//System.Console.WriteLine(salesMan1.EmpID);
		//System.Console.WriteLine(salesMan1.EmpName);
		//System.Console.WriteLine(salesMan1.Location);
		//System.Console.WriteLine(salesMan1.GetSalesOfTheCurrentMonth());
		//System.Console.WriteLine(salesMan1.GetHelthInsurianceAmount());

		//crate object of SalesMan
		emp = new SalesMan(101, "John", "Washington", "East");

		System.Console.WriteLine(emp.GetHelthInsurianceAmount());
		System.Console.WriteLine();



		System.Console.ReadKey();

	}
}