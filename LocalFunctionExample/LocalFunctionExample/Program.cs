class Student
{
	//method
	public void DisplayMarks(int marks1, int marks2, int marks3)
	{
		double avgMArks = getAverageMarks(marks1, marks2, marks3);
		System.Console.WriteLine("Marks 1: " + marks1);
		System.Console.WriteLine("Marks 2: " + marks2);
		System.Console.WriteLine("Marks 3: " + marks3);
		System.Console.WriteLine("Average marks: " + avgMArks);

		//create local function
		double getAverageMarks(int m1, int m2, int m3)
		{
			//create local variable of local function
			double avg;
			avg = (double)(m1 + m2 + m3) / 3;
			return avg;
		}

	}
}

class Program
{
	static void Main()
	{
		Student s = new Student();

		s.DisplayMarks(80, 45, 71);

		System.Console.ReadKey();
	}
}