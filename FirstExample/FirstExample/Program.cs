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
                new Employee(){EmpID=105, EmpName="Alexa",Job="Manager",City="New York", Salary = 6232}
            };

            //Where
            List<Employee> filteredEmployees =  employees.Where(emp => emp.Job =="Manager").ToList();
            Console.WriteLine(filteredEmployees[0].EmpID +", " + filteredEmployees[0].EmpName);
            Console.WriteLine(filteredEmployees[1].EmpID +", " + filteredEmployees[1].EmpName);
            //Console.WriteLine(filteredEmployees[2].EmpID +", " + filteredEmployees[2].EmpName);//runtime error System.ArgumentOutOfRangeException: 'Index was out of range. Must be non-negative and less than the size of the collection. Parameter name: index'

            //First 
            Employee filteredEmployeesFirst = employees.First(emp => emp.Job == "Manager"); //System.InvalidOperationException: 'Sequence contains no matching element'

            Console.WriteLine(filteredEmployeesFirst.EmpID + ", " + filteredEmployeesFirst.EmpName);            
            
            //First or default
            Employee filteredEmployeesFirstOrDefault = employees.FirstOrDefault(emp => emp.Job == "Manager2"); //System.InvalidOperationException: 'Sequence contains no matching element'
            if (filteredEmployeesFirstOrDefault != null)
            {
                Console.WriteLine("First or default: " + filteredEmployeesFirstOrDefault.EmpID + ", " + filteredEmployeesFirstOrDefault.EmpName); //System.NullReferenceException: 'Object reference not set to an instance of an object.'
            } else
            {
                Console.WriteLine("No record!");
            }

            //First or default
            Employee filteredEmployeesFirstOrDefault2 = employees.OrderByDescending(emp => emp.EmpName).FirstOrDefault(emp => emp.Job == "Manager2"); 
            if (filteredEmployeesFirstOrDefault2 != null)
            {
                Console.WriteLine("First or default: " + filteredEmployeesFirstOrDefault2.EmpID + ", " + filteredEmployeesFirstOrDefault2.EmpName); 
            }
            else
            {
                Console.WriteLine("No record!");
            }


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

            //IOrderedEnumerable<Employee> sortedEmployees = employees.OrderByDescending(emp => emp.Job)
            //    .ThenByDescending(emp => emp.EmpName).ThenByDescending(emp => emp.EmpID);

            //foreach (Employee item in sortedEmployees)
            //{
            //    Console.WriteLine(item.EmpID + ", " + item.EmpName + ", " + item.Job + ", " + item.City + ", " + item.Salary);
            //}

            Console.ReadKey();
        }
    }
}
