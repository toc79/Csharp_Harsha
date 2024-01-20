using System.Runtime.Remoting.Messaging;

class Student
{
	// public field
	public int grade = 2;

	//public method
	public void PrintGrade()
	{
		System.Console.WriteLine("Grade: " + grade);
	}

	public ref int DoWork()
	{
		//return reference of 'grade' field
		return ref grade;
	}
}

class Program
{
	static void Main()
	{
		//creating object of Student
		Student s = new Student();
		
		//call PrintGrade
		s.PrintGrade();

		//call DoWork
		ref int g = ref s.DoWork();

		//update value of 'ref return'
		g = 5;

		// call PrintGrade after updateing the value of 'ref return'
		s.PrintGrade();

		System.Console.ReadKey();
	}
}