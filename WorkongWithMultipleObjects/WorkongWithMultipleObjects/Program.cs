class WorkongWithMultipleObjects
{
	static void Main()
	{
		Employee.OrganizationName = "Harsha Inc.";
		// create object
		Employee employee1, employee2, employee3, employee4, employee5;
		employee1 = new Employee();
		employee2 = new Employee();
		employee3 = new Employee();
		employee4 = new Employee();
		employee5 = new Employee();

		employee1.emplID = 1;
		employee1.empName = "John Malković";
		employee1.salaryPerHour = 10;
		employee1.noOfWorkingHours = 40;	
		
		employee2.emplID = 2;
		employee2.empName = "Eric Zappa";
		employee2.salaryPerHour = 12;
		employee2.noOfWorkingHours = 40;	
		
		employee3.emplID = 3;
		employee3.empName = "Elvis Presly";
		employee3.salaryPerHour = 13;
		employee3.noOfWorkingHours = 40;	
		
		employee4.emplID = 4;
		employee4.empName = "Bruce Springsten";
		employee4.salaryPerHour = 14;
		employee4.noOfWorkingHours = 40;	
		
		employee5.emplID = 5;
		employee5.empName = "Pearl Jam";
		employee5.salaryPerHour = 15;
		employee5.noOfWorkingHours = 40;

		int pressedKey = -1;

		do
		{
			System.Console.WriteLine("Enter Employee ID (from 1 to 5)");
			//System.Console.WriteLine("Enter 0 for exit");
			System.Console.Write("Enter choice:");
			pressedKey = int.Parse(System.Console.ReadLine());
			switch (pressedKey)
			{
				//case 0:
					//break;
				case 1:
					//PrintCustomer1();
					System.Console.WriteLine("Employee ID: " + employee1.emplID);
					System.Console.WriteLine("Employee Name: " + employee1.empName);
					System.Console.WriteLine("Salary Per Hour: " + employee1.salaryPerHour);
					System.Console.WriteLine("Number Of Working Hours: " + employee1.noOfWorkingHours);
					System.Console.WriteLine("Net Salary: " + (employee1.salaryPerHour * employee1.noOfWorkingHours));
					System.Console.WriteLine("Organization Name: " + Employee.OrganizationName);
					System.Console.WriteLine("Type Of Employee: " + Employee.TypeOfEmployee);
					System.Console.WriteLine("Department Name: " + employee1.departmentName);
					break;
				case 2:
					//PrintCustomer2();
					System.Console.WriteLine("Employee ID: " + employee2.emplID);
					System.Console.WriteLine("Employee Name: " + employee2.empName);
					System.Console.WriteLine("Salary Per Hour: " + employee2.salaryPerHour);
					System.Console.WriteLine("Number Of Working Hours: " + employee2.noOfWorkingHours);
					System.Console.WriteLine("Net Salary: " + (employee2.salaryPerHour * employee2.noOfWorkingHours));
					System.Console.WriteLine("Organization Name: " + Employee.OrganizationName);
					System.Console.WriteLine("Type Of Employee: " + Employee.TypeOfEmployee);
					System.Console.WriteLine("Department Name: " + employee2.departmentName);
					break;
				case 3:
					//PrintCustomer3();
					System.Console.WriteLine("Employee ID: " + employee3.emplID);
					System.Console.WriteLine("Employee Name: " + employee3.empName);
					System.Console.WriteLine("Salary Per Hour: " + employee3.salaryPerHour);
					System.Console.WriteLine("Number Of Working Hours: " + employee3.noOfWorkingHours);
					System.Console.WriteLine("Net Salary: " + (employee3.salaryPerHour * employee3.noOfWorkingHours));
					System.Console.WriteLine("Organization Name: " + Employee.OrganizationName);
					System.Console.WriteLine("Type Of Employee: " + Employee.TypeOfEmployee);
					System.Console.WriteLine("Department Name: " + employee3.departmentName);
					break;
				case 4:
					//PrintCustomer4();
					System.Console.WriteLine("Employee ID: " + employee4.emplID);
					System.Console.WriteLine("Employee Name: " + employee4.empName);
					System.Console.WriteLine("Salary Per Hour: " + employee4.salaryPerHour);
					System.Console.WriteLine("Number Of Working Hours: " + employee4.noOfWorkingHours);
					System.Console.WriteLine("Net Salary: " + (employee4.salaryPerHour * employee4.noOfWorkingHours));
					System.Console.WriteLine("Organization Name: " + Employee.OrganizationName);
					System.Console.WriteLine("Type Of Employee: " + Employee.TypeOfEmployee);
					System.Console.WriteLine("Department Name: " + employee4.departmentName);
					break;
				case 5:
					//PrintCustomer5();
					System.Console.WriteLine("Employee ID: " + employee5.emplID);
					System.Console.WriteLine("Employee Name: " + employee5.empName);
					System.Console.WriteLine("Salary Per Hour: " + employee5.salaryPerHour);
					System.Console.WriteLine("Number Of Working Hours: " + employee5.noOfWorkingHours);
					System.Console.WriteLine("Net Salary: " + (employee5.salaryPerHour * employee5.noOfWorkingHours));
					System.Console.WriteLine("Organization Name: " + Employee.OrganizationName);
					System.Console.WriteLine("Type Of Employee: " + Employee.TypeOfEmployee);
					System.Console.WriteLine("Department Name: " + employee5.departmentName);
					break;
			}

			string pressedKeyForNextEmployee = "no";
			System.Console.Write("Do you want to continue to next employee (type Yes):");
			pressedKeyForNextEmployee = System.Console.ReadLine();
			if (pressedKeyForNextEmployee.ToLower() != "yes")
				pressedKey = 0;
		}
		while (pressedKey != 0);

		
	}

	//static void PrintCustomer1()
	//{
	//	//System.Console.WriteLine("Employee ID: " +employee1.emplID);
	//	}
}