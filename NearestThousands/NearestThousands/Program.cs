class NearestThousand
	{
		static void Main()
		{
			int input = 40500;

			int thousands = input / 1000;

			int lastThreeDigits = input - thousands * 1000;

			int multiplier = (lastThreeDigits >= 500) ? 1000 : 0;
			//input <= 1455 ? 1000 :
			int output = input <= 499 ? 1000 : thousands * 1000 + multiplier;

			System.Console.WriteLine("Input: " +input);
			System.Console.WriteLine("Thousands: " +thousands);
			System.Console.WriteLine("Last three digits: " +lastThreeDigits);
			System.Console.WriteLine("Output: " + output);
			System.Console.ReadKey();
		}
	}

