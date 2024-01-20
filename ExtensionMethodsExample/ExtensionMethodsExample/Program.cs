using ClassLibrary1;
using System;
using ExtensionNamespace;

namespace ExceptionMethodExample
{
	class Program
	{
		static void Main()
		{
			//create object
			Product p = new Product() { ProductCost = 1000, DiscontPercentage = 10 };

			//call the extension method
			Console.WriteLine(p.GetDiscont());
			Console.ReadKey();
		}
	}
}