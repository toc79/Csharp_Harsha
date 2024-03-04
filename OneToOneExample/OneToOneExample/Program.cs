using System;
using Collegge;

namespace OneToOneExample
{
	class Program
	{
		static void Main()
		{
			//student class's object
			Student student = new Student();
			student.RollNo = 123;
			student.StudentName = "Scott";
			student.Email = "scott@gmail.com";

			//Branch class's object
			//Branch br = new Branch();
			//br.BranchName = "Computer Science Engineering";
			//br.NoOfSemesters = 8;

			//one-to-one relation // Object reletions
			//student.branch = br;

			//Branch class's object 
			student.branch = new Branch();
			student.branch.BranchName = "Computer Science Engineering";
			student.branch.NoOfSemesters = 8;

			//display
			Console.WriteLine(student.RollNo);
			Console.WriteLine(student.StudentName);
			Console.WriteLine(student.Email);
			Console.WriteLine(student.branch.BranchName);
			Console.WriteLine(student.branch.NoOfSemesters);

			Console.ReadKey();
		}
	}
}
