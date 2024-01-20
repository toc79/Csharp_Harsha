using System;
using System.Collections.Generic;


namespace AddExample
{
	internal class Program
	{
		static void Main()
		{
			//create reference variable for List class & and create object of List class
			List<int> myList = new List<int>(10) {10, 20, 30 };


			//add new element using foreach loop
			myList.Add(40);

			//another collection
			List<int> otherList = new List<int>() { 50, 60, 70};

			myList.AddRange(otherList);

			//read elements using foreach loop
			Console.WriteLine("Using foreach loop: ");
			foreach(int item in myList)
			{
				Console.WriteLine(item);
			}

			Console.ReadKey();
		}
	}
}
