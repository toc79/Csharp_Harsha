using System;
using College;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;

namespace OneToManyExample
{
	class Program
	{
		static void Main()
		{
			//create object of student class
			Student student = new Student();
			student.RollNo = 1;
			student.StudentName = "Allen";
			student.Email = "allen@gmail.com";
			student.examination = new List<Examination>();
			student.examination.Add(new Examination () { ExaminationName = "Module Test1", Month = 5, Year= 2021, MaxMarks = 100, SecuredMarks = 87});
			student.examination.Add(new Examination () { ExaminationName = "Module Test2", Month = 7, Year= 2022, MaxMarks = 100, SecuredMarks = 70});
			student.examination.Add(new Examination () { ExaminationName = "Module Test3", Month = 3, Year= 2024, MaxMarks = 100, SecuredMarks = 91});

			//print
			Console.WriteLine("Roll No: " + student.RollNo);
			Console.WriteLine("Studen Name: " + student.StudentName);
			Console.WriteLine("Email: " + student.Email);
			foreach (Examination exam in student.examination )
			{
				Console.WriteLine(exam.ExaminationName + ", " + exam.Year + "-" + exam.Month + ", " + exam.SecuredMarks + "/" + exam.MaxMarks);
			}
			Console.ReadKey();
		}
	}
}
