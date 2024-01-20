class Program
{
	static void Main()
	{
		//create object
		Sample sample = new Sample();
		Employee emp = new Employee() { Saalary = 1000};
		Student stu = new Student() { Marks = 80 };


		//call generic method
		sample.PrintData<Employee>(emp);
		sample.PrintData<Student>(stu);

		
		//da li je ovo kreće tj. podržali su shorthand??
		//call generic method 
		sample.PrintData(emp);
		sample.PrintData(stu);

		System.Console.ReadKey();
	}
}