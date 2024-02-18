using System;
using System.Collections.Generic;

namespace StackExample
{
	class Student
	{
		public int Marks { get; set; }
		public int Rank{ get; set; }
	}
	
	class Program
	{
		static void Main()
		{
			//create object of Stack
			Stack<int> marks = new Stack<int>();

			//Add
			marks.Push(45);
			marks.Push(61);
			marks.Push(80);

			//foreach
			foreach(int item in marks)
			{
				Console.WriteLine(item);
			}

			Console.WriteLine("");

			//create object of Stack for Student
			Stack<Student> marks2 = new Stack<Student>();

			//Add
			marks2.Push(new Student() { Marks = 45 });
			marks2.Push(new Student() { Marks = 61 });
			marks2.Push(new Student() { Marks = 80 });

			//Pop
			//Student stu = marks2.Pop();
			//Console.WriteLine("Pop: " + stu.Marks);

			//Peek
			Student stu = marks2.Peek();
			Console.WriteLine("Peek: " + stu.Marks);

			int r = 1;
			//foreach
			foreach (Student item in marks2)
			{
				item.Rank = r;
				Console.WriteLine(item.Marks + ", " +item.Rank);
				r++;
			}

			Console.ReadKey();
		}
	}
}
