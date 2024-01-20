using System;
using ClassLibrary1;

namespace MultiCastDelegatesExample
{
	class Program
	{
		static void Main()
		{
			//create object of Sample
			Sample s = new Sample();

			//create reference type of MyDelegateType
			MyDelegateType myDelegate;

			//add reference of first target method 
			//myDelegate = new MyDelegateType(s.Add);
			myDelegate = s.Add;

			//add ref of second method
			myDelegate += s.Multiply;

			//invoke both target methods; first Add method; then Multiply method
			myDelegate.Invoke(40, 10);

			Console.ReadKey();
		}
	}
}
