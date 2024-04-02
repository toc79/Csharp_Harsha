using System;
using System.Collections.Generic;

namespace IComparableExample
{
    public class Employee : IComparable
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public string Job { get; set; }

        //public int CompareTo(object other)
        //{
        //    //Employee otherEmp = other as Employee;
        //    Employee otherEmp = (Employee)other;
        //    Console.WriteLine("this: " + this.EmpID +", other/obj: " +  otherEmp.EmpID);
        //    return this.EmpID - otherEmp.EmpID ;
        //}

        public int CompareTo(object other)
        {
            //Employee otherEmp = other as Employee;
            Employee otherEmp = (Employee)other;
            Console.WriteLine("this: " + this.EmpID + ", other/obj: " + otherEmp.EmpID);
            return this.EmpName.CompareTo(otherEmp.EmpName);
        }
    }
    
    class Program
    {
        static void Main()
        {
            //list of employee
            List<Employee> employees = new List<Employee>()
            {
                new Employee() {EmpID = 104, EmpName = "Mary", Job = "Designer"},
                new Employee() {EmpID = 102, EmpName = "Alexa", Job = "Manager"},
                new Employee() {EmpID = 101, EmpName = "Steven", Job ="Consultan"},
                new Employee() {EmpID = 103, EmpName = "Jade", Job ="Analyst"}
            };

            employees.Sort();

            foreach(Employee item in employees)
            {
                Console.WriteLine(item.EmpID +", "+item.EmpName +", "+ item.Job);
            }

            Console.ReadKey();

        }
    }
}
