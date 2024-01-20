class Program
{
	static void Main()
	{
		//read input value from keyboard
		string s;
		System.Console.WriteLine("Enter number:");
		s = System.Console.ReadLine();

		//TryParse
		bool b = int.TryParse(s, out int n);
		if (b== true)
		{
			System.Console.WriteLine("Parsing/conversion is successful");
			System.Console.WriteLine(n);
		}
		else
		{
			System.Console.WriteLine("Parsing/conversion failed");
		}

		System.Console.ReadKey();

	}
}