using System;
using System.Collections.Generic;

namespace IEnumerableExample
{
	class Program
	{
		static void Main()
		{
			//create collection
			IEnumerable<string> messages;
			messages = new List<string>() { "How are you", "Have a nice day", "Thanks for meeting" };

			//foreach
			Console.WriteLine("IEnumerable:");
			foreach (string item in messages)
			{
				Console.WriteLine(item);
			}


			//IEnumerator
			Console.WriteLine("\nIEnumerator:");
			IEnumerator<string> enumerator = messages.GetEnumerator();
			enumerator.Reset();
			//enumerator.MoveNext();
			//Console.WriteLine(enumerator.Current);
			//enumerator.MoveNext();
			//Console.WriteLine(enumerator.Current);
			//enumerator.MoveNext();
			//Console.WriteLine(enumerator.Current);

			Console.WriteLine("\nIEnumerator While loop:");
			while (enumerator.MoveNext())
			{
				Console.WriteLine(enumerator.Current);
			}

			Console.ReadKey();

		}
	}
}
