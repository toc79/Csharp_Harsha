using System;
using System.Collections.Generic;
using Company;

namespace ManyToOneExample
{
	class Program
	{
		static void Main()
		{
			//Three employees in the same department
			Employee employee1 = new Employee() {EmployeeID=1, EmployeeName ="Scott", Email = "scott@gmail.com" };
			Employee employee2 = new Employee() {EmployeeID=2, EmployeeName ="Allen", Email = "allen@gmail.com" };
			Employee employee3 = new Employee() {EmployeeID=3, EmployeeName ="Smith", Email = "smith@gmail.com" };

			//create object of Department class
			Department department = new Department() { DepratmentID = 10, DepartmentName = "Accounting" };

			employee1.dept = department;
			employee2.dept = department;
			employee3.dept = department;

		}
	}
}
