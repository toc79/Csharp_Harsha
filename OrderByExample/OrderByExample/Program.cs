using System;
using System.Collections.Generic;
using System.Linq;

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
                new Employee(){EmpID=105, EmpName="Alexa",Job="Manager",City="New York", Salary = 6232}
            };

            //var result = employees.Where(emp => emp.Job == "Manager"); //var is of IEnumerable<Employee>
            //var result = employees.Where(emp => emp.City == "New York");
            //IEnumerable<Employee> result = employees.Where(emp => emp.City == "New York");
            //IEnumerable<Employee> result = employees.Where(emp => emp.City == "London");

            //foreach (Employee item in result)
            //{
            //    Console.WriteLine(item.EmpID + ", " + item.EmpName + ", " + item.Job + ", " + item.City);
            //}

            //IOrderedEnumerable<Employee> sortedEmployees = employees.OrderBy(emp => emp.EmpName);
            //IEnumerable<Employee> sortedEmployees = employees.OrderBy(emp => emp.Salary);

            //IOrderedEnumerable<Employee> sortedEmployees = employees.OrderByDescending(emp => emp.Salary);
            //IOrderedEnumerable<Employee> sortedEmployees = employees.OrderBy(emp => emp.Job)
                //.ThenBy(emp => emp.EmpName) ;
            
            IOrderedEnumerable<Employee> sortedEmployees = employees.OrderByDescending(emp => emp.Job)
                .ThenByDescending(emp => emp.EmpName).ThenByDescending(emp => emp.EmpID) ;

            foreach (Employee item in sortedEmployees)
            {
                Console.WriteLine(item.EmpID + ", " + item.EmpName + ", " + item.Job + ", " + item.City +", "+ item.Salary);
            }

            Console.ReadKey();
        }
    }
}
