class Student
{
	public void DisplaySubjects(params string[] subject)
	{
		//recive all subject as an arry using 'params' modifier

		for (int i = 0; i < subject.Length; i++)
		{
			System.Console.WriteLine(subject[i]);
		}

		//System.Console.WriteLine(subject[0]);
		//System.Console.WriteLine(subject[1]);
		//System.Console.WriteLine(subject[2]);
		//System.Console.WriteLine(subject[3]);
		//System.Console.WriteLine(subject[4]); //System.IndexOutOfRangeException: 'Index was outside the bounds of the array.'

	}
}

class Program
{
	static void Main()
	{
		// create object of Student class
		Student s = new Student();

		//access DisplaySubject method
		s.DisplaySubjects("Subject 1", "Subject 2", "Subject 3", "Subject 4", "Subject 5");
		System.Console.ReadKey();
	}
}