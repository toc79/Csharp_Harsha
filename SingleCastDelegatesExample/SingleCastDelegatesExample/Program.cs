﻿using ClassLibrary1;
using System;

namespace SingleCastDelegatesExample
{
	class Program
	{
		static void Main()
		{
			//create object of the Sample class
			Sample s = new Sample();

			//create delegate object (or) delegate
			MyDelegateType myDelegate;

			//add method reference to delegate 
			myDelegate = new MyDelegateType(s.Add);

			//invoke method using delegate object 
			Console.WriteLine(myDelegate.Invoke(30, 40));

			Console.ReadKey();

		}
	}
}
