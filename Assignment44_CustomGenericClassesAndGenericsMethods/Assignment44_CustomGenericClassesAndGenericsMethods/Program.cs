//Assignment: Custom Generic Classes and Generic Methods
//In this assignment, you will create a custom implementation of a key-value database using arrays.You will create a Database<TKey, TValue> class that provides basic functionality for adding, removing, and retrieving key-value pairs.

//Part 1: Create a Custom Generic Class
//Create a Database<TKey, TValue> class that implements a simple key-value database using two arrays. This class should have the following methods:

//void Add(TKey key, TValue value): adds a new key- value pair to the database.

//bool Remove(TKey key): removes the key-value pair with the specified key from the database. Returns true if the pair was removed, false otherwise.

//bool TryGetValue(TKey key, out TValue value): retrieves the value associated with the specified key. Returns true if the key was found, false otherwise.

//int Count { get; }: returns the number of key-value pairs in the database.


//The Database<TKey, TValue> class should use two arrays to store the keys and values. When a new key- value pair is added to the database, it should be appended to the end of the arrays. If the arrays are full, they should be resized to twice their current size.

//When a key-value pair is removed, the class should search the keys array for the key to remove. If the key is found, the corresponding value should be removed from the values array, and the remaining elements should be shifted to the left to fill the gap. If the number of elements in the arrays falls below one-fourth of the array capacity, the arrays should be resized to half their current size.

//The TryGetValue method should search the keys array for the specified key and return the corresponding value if it is found.

//Part 2: Create a Generic Method
//Create a generic method Swap<T>(ref T a, ref T b) that takes two parameters of type T by reference and swaps their values.

//Part 3: Test Your Code
//Create a console application and use it to test your Database<TKey, TValue> class and Swap<T> method.

//In the Main method of the console application, create a Database<int, string> object and add some key-value pairs to it. Then, use the Remove method to remove one of the pairs, and use the TryGetValue method to retrieve the value associated with another key. Print the number of key-value pairs in the database using the Count property.

//Next, create two variables of type int and swap their values using the Swap< int > method.Then, create two variables of a custom class of your choice and swap their values using the Swap< T > method.

//Sample output:
//A pair of key/value has been added to the database.
//A pair of key/value has been added to the database.
//A pair of key/value has been added to the database.
//A pair of key/value has been added to the database.
//Before remove:
//Count: 4
//Value for key 2: Two
//After remove:
//Count: 3
//a = 2, b = 1
//c1.Value = 2, c2.Value = 1

using System;

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
