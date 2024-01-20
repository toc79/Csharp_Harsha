using System;

namespace ArrayExample
{
	class Program
	{
		static void Main()
		{
			//create array
			int[] a = new int[5] { 10, 20, 30, 40, 50};
			string[] b = new string[5] { "one", "two", "three", "four", "five"};

			//display the value of element
			//Console.WriteLine(a[0]);
			//Console.WriteLine(a[1]);
			//Console.WriteLine(a[2]);
			//Console.WriteLine(a[3]);
			//Console.WriteLine(a[4]);
			//Console.WriteLine();
			//Console.WriteLine(b[0]);
			//Console.WriteLine(b[1]);
			//Console.WriteLine(b[2]);
			//Console.WriteLine(b[3]);
			//Console.WriteLine(b[4]);

			for(int i=0; i<a.Length; i++)
			{
				Console.WriteLine(a[i]);
			}

			Console.WriteLine();

			for (int i=0; i<b.Length; i++)
			{
				Console.WriteLine(b[i]);
			}
			Console.WriteLine();

			foreach(int i in a)
			{
				Console.WriteLine(i);
			}

			Console.WriteLine();

			foreach (string i in b)
			{
				Console.WriteLine(i);
			}

			Console.WriteLine();

			//revrse
			Console.WriteLine("Revrse");
			for (int i = b.Length -1; i >= 0; i--)
			{
				
				Console.WriteLine(b[i]);
			}

			Console.ReadKey();
		}
	}
}
