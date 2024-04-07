using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace LINQExample
{
    class Employee
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public string Job { get; set; }
        public string City { get; set; }
        public double Salary { get; set; }
    }

    class Program
    {
        static void Main()
        {
            //collection of objects
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){EmpID=101, EmpName="Henry",Job="Designer",City="Boston", Salary = 7232},
                new Employee(){EmpID=102, EmpName="Jack",Job="Deveoper",City="New York", Salary = 4500},
                new Employee(){EmpID=103, EmpName="Gabriel",Job="Analyst",City="Tokyo", Salary = 1293},
                new Employee(){EmpID=104, EmpName="William",Job="Manager",City="Tokyo", Salary = 2873},
                new Employee(){EmpID=105, EmpName="Alexa",Job="Manager",City="New York", Salary = 6232},
                new Employee(){EmpID=105, EmpName="Jessica",Job="Manager",City="New York", Salary = 6232}
            };

           //ElementAt
            //employees.Where()

            if (filteredEmployeesFirstOrDefault2 != null)
            {
                Console.WriteLine("First or default: " + filteredEmployeesFirstOrDefault2.EmpID + ", " + filteredEmployeesFirstOrDefault2.EmpName);
            }
            else
            {
                Console.WriteLine("No record!");
            }




            Console.ReadKey();
        }
    }
}
