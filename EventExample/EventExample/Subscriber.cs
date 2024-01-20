using System;
using ClassLibrary1;

namespace EventExample
{
	internal class Subscriber
	{
		//target method
		public void Add(int a, int b)
		{
			int c = a + b;
			Console.WriteLine(c);
		}
	}
}
