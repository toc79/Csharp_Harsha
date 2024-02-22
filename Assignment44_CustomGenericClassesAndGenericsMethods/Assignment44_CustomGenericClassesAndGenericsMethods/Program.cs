using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Assignment44_CustomGenericClassesAndGenericsMethods
{
	
	public class DatabaseClass<TKey, TValue>
	{
		public TKey[] tkey = new TKey[3];
		public TValue[] tvalue = new TValue[3];

		public void Add(TKey key, TValue value)
		{
			int tkeyLenght = tkey.Length;
			//int tValueLength = tvalue.Length; // there is no need for counting that array

			Console.WriteLine("tkeyLenght: " + tkeyLenght);
			//Console.WriteLine("tkey.GetUpperBound(tkeyLenght -1): " + tkey.GetUpperBound(tkeyLenght-1));

			if (tkeyLenght == 0)
			{
				Array.Resize(ref tkey, tkeyLenght + 1);
				//Array.Resize(ref tvalue, tValueLength + 1);
				Array.Resize(ref tvalue, tkeyLenght + 1);
			}
			
			
			//tkey.SetValue(key, tkeyLenght);
			//tvalue.SetValue(value, tValueLength);
			//tvalue.SetValue(value, tkeyLenght);

			//Console.WriteLine("TKey of first element: " + tkey[tkeyLenght]);
			//Console.WriteLine("TValue of first element: " + tvalue[tkeyLenght]);
			
			//int no_of_elements = tkey.GetLength(tkeyLenght);
			//Console.WriteLine("no_of_elements: " + no_of_elements);

			

			//Array.Resize(ref tkey, tkeyLenght * 2);
			//Array.Resize(ref tvalue, tValueLength * 2);

			tkeyLenght = tkey.Length;
			//tValueLength = tvalue.Length;

			Console.WriteLine("Length of tkey is now: " + tkeyLenght);
			//Console.WriteLine("Length of tvalue is: " + tValueLength);

			

			//tkey.SetValue()
		}
	}
	
	class Program
	{
		static void Main()
		{
			DatabaseClass<int, string> dc = new DatabaseClass<int, string>();

			dc.Add(1, "test 1");
			//dc.Add(2, "test 2");

			Console.ReadKey();
		}
	}
}
