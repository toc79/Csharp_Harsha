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
			Branch br = new Branch();
			br.BranchName = "Computer Science Engineering";
			br.NoOfSemesters = 8;

			//one-to-one reletion // Object reletions
			student.branch = br;
		}
	}
}
