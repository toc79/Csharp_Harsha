using System;
using System.Collections.Generic;

namespace IComparerExample
{
    public class Employee
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public string Job { get; set; }
    }

    public enum SortBy
    {
        EmpID, EmpName, Job
    }

    class CustomComparer : IComparer<Employee>
    {
        //public int Compare(Employee x, Employee y)
        //{
        //    return x.EmpID - y.EmpID;
        //}
        //public int Compare(Employee x, Employee y)
        //{
        //    return x.EmpName.CompareTo(y.EmpName) ;
        //}

        //public int Compare(Employee x, Employee y)
        //{
        //    int result = 0;
        //    if (x.Job != null && y.Job != null)
        //    {
        //        result = x.Job.CompareTo(y.Job);//first sorting columns
        //    }


        //    if (result == 0)
        //    {
        //        if (x.EmpName != null && y.EmpName != null)
        //        {
        //            result = x.EmpName.CompareTo(y.EmpName);//second sorting columns
        //        }
        //    }

        //    return result;
        //}

        public int Compare(Employee x, Employee y)
        {
            int result = 0;
            switch (this.sortBy)
            {
                case SortBy.EmpID:
                    result = x.EmpID - y.EmpID;
                    break;
                case SortBy.EmpName:
                    result = (x.EmpName != null && y.EmpName != null) ? x.EmpName.CompareTo(y.EmpName) : 0 ;//second sorting columns
                    break;
                case SortBy.Job:
                    result = (x.Job != null && y.Job != null) ? x.Job.CompareTo(y.Job) : 0 ;//first sorting columns
                    break;
                default:
                    result = 0 ;
                    break;

            }
            return result;
        }

        public SortBy sortBy { get; set; }
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
                new Employee() {EmpID = 103, EmpName = "Jade", Job ="Manager"},
                new Employee() {EmpID = 105, EmpName = "Sara", Job =null}
            };
            
            CustomComparer customComparer = new CustomComparer();
            customComparer.sortBy = SortBy.Job; 

            employees.Sort(customComparer);
            

            //employees.Reverse();

            foreach (Employee item in employees)
            {
                Console.WriteLine(item.EmpID + ", " + item.EmpName + ", " + item.Job);
            }

            Console.ReadKey();
        }
    }
}
