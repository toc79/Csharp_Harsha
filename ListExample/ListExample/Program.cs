using System;
using System.Collections;
using System.Collections.Generic;

namespace ListExample
{
	internal class Program
	{
		static void Main()
		{
			//create reference varable for List class
			//List<int> myList;

			//create object of the List class
			//myList = new List<int>() {12, 20,30 };

			//create reference varable for List class & create object of the List class
			List<int> myList = myList = new List<int>(10) { 12, 20, 30 };

			//read element using foreach loop
			foreach (int item in myList)
			{
				Console.WriteLine(item);
			}


			for(int i = 0; i < myList.Count; i++)
			{
				Console.WriteLine(myList[i]);
			}

			Console.ReadKey();
		}
	}
}
