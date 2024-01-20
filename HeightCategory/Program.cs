class HeightCategory
{
	static void Main()
	{
		int input = 75;
		
		double intchesToCentimeterFactor = 2.54; 

		double centimeters = input * intchesToCentimeterFactor;

		string output;

		if (centimeters < 150)
		{
			output = "Dwarf";
		} 
		else if (centimeters >= 150 && centimeters < 165)
		{
			output = "Average height";
		}
		else if (centimeters >= 165 && centimeters < 195)
		{
			output = "Tall";
		}
		else
		{
			output = "Abnormal height";
		}

		System.Console.WriteLine(output);
		System.Console.ReadKey();
	}
}