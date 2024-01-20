using System;
using System.Security.Policy;
using ClassLibrary1;

namespace EventExample
{
	class Program
	{
		static void Main()
		{
			//create object of Subscriber class
			Subscriber suscriber = new Subscriber();

			//create object of Publisher class
			Publiser publiser = new Publiser();

			//handle the event (or) subscribe to event
			publiser.myEvent += suscriber.Add;

			//invoke the event
			publiser.RaiseEvent(10, 20);

			Console.ReadKey();
		}

	}
}
