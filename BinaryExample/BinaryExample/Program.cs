using System;

namespace BinaryExample
{
	internal class Program
	{
		static void Main()
		{
			int dec1 = 13;

			string binary1 = Convert.ToString(dec1, 2); //decimal into binart
			Console.WriteLine(binary1);

			int dec2 = Convert.ToInt32(binary1, 2); //binary to decimal
			Console.WriteLine(dec2);

			//binary literals
			Console.WriteLine(0b1100100); //100

			int n = 0b1100100;
			n += 1;
			Console.WriteLine(n);

			Console.ReadKey();
		}
	}
}
