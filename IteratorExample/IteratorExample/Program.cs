using System;
using System.Collections.Generic;

namespace IteratorExample
{
	class Sample
	{
		public List<double> Prices { get; set; } = new List<double>() { 90, 34, 12, 80};
		
		//Iterator method 
		public IEnumerable<double> Method()
		{
			double sum = 0;

			foreach (double price in Prices)
			{
				sum += price;
				yield return sum;
			}
			//manually
			//sum += Prices[0];
			//yield return sum;

			//sum += Prices[1];
			//yield return sum;

			//sum += Prices[2];
			//yield return sum;

			//sum += Prices[3];
			//yield return sum;
		}
		
		//public IEnumerable<int> Method()
		//{
		//	Console.WriteLine("Iterator method execute");
		//	yield return 10;
		//	Console.WriteLine("Iterator method executes continued");
		//	yield return 20;
		//}
	}
	class Program
	{
		static void Main()
		{
			Sample s = new Sample();
			var prices_enumerable = s.Method();
			var prices_enumerator = prices_enumerable.GetEnumerator();
			prices_enumerator.MoveNext(); //90
			Console.WriteLine("Total price up to first product: " + prices_enumerator.Current); //90
			Console.WriteLine("Some more code"); //90
			
			prices_enumerator.MoveNext(); //90
			Console.WriteLine("Total price up to second product: " + prices_enumerator.Current); //124
			Console.WriteLine("Some more code"); //90


			//Console.WriteLine(prices_enumerator.Current);
			//prices_enumerator.MoveNext();
			//Console.WriteLine(prices_enumerator.Current);

			//foreach replaces GetEnumerator internaly
			//foreach(var item in prices_enumerable)
			//{
			//	Console.WriteLine(item);
			//}


			Console.ReadKey();
		}
	}
}
