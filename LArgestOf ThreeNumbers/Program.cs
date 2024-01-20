class LargestOfThreeNumbers
{
	static void Main()
	{
		int num1 = 60;
		int num2 = 45;
		int num3 = 123;

		int largestNumber;
		if (num1 > num2)
		{
			largestNumber = num1;
		}
		else
		{
			largestNumber = num2;
		}

		if (num3 > largestNumber)
		{
			largestNumber = num3;
		}

		System.Console.WriteLine(largestNumber);
		System.Console.ReadKey();
	}
}