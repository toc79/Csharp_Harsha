class Sample
{
	public double Factorial(int number)
	{
		if (number == 0)
		{
			return 1;
		}
		else
		{
			return number * Factorial(number - 1);
		}
	}
}

class Program
{
	static void Main()
	{
		//read number form keyboard
		System.Console.WriteLine("Enter a number:");
		int n = int.Parse(System.Console.ReadLine());

		//create object 
		Sample s = new Sample();
		
		//call Factorial
		double f = s.Factorial(n);
		System.Console.WriteLine("Factorial of " + n +" is " + f);
		System.Console.ReadKey();
	}
}