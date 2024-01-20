using System;
using System.ComponentModel;
using ClassLibrary1;

namespace IDisposableExample
{
	class Program
	{
		static void DoWork()
		{
			//create object using "using declaration"

			Sample s = new Sample();
			//using Sample s = new Sample();
			s.DisplayDataFromDatabase();

		} //Dispose gets called here 

		static void Main()
		{

			DoWork();
			
			
			//create object using "using structure"

			using (Sample s = new Sample())
			{
				s.DisplayDataFromDatabase();

			}

			Console.WriteLine("Some work here");

			Console.ReadKey();
		}
	}
}
