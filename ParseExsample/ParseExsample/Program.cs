class Program
{
	static void Main()
	{
		//string
		string a = "10 0";

		//int
		int b;
		
		b = int.Parse(a);
		System.Console.WriteLine(a); //"100" as string
		System.Console.WriteLine(b); //100 as int

		System.Console.ReadKey();
			
	}
}