﻿using System;
using ClassLibrary1;

namespace ExpressionBodiedMembersExample
{
	class Program
	{
		static void Main()
		{
			//create object of student class
			Student s = new Student() { StudentName = "Scott" };

			Console.WriteLine(s.StudentName);
			Console.WriteLine(s.GetStudentNameLenght());

			Console.ReadKey();

		}
	}
}
