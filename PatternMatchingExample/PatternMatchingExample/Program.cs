using System;
using ClassLibrary1;

namespace PaternMatchingExample 
{ 
	class Program
	{
		static void Main()
		{
			//reference variable of the ParentClasss
			ParentClass pc;
			
			//object of the child class
			pc = new ChildClass() { x = 10, y = 20};

			//access parent class's members 
			//Console.WriteLine(pc.x);
			//Console.WriteLine(pc.y);

			//if (pc is ChildClass)
			//{
			//	ChildClass cc = (ChildClass)pc;
				
			//	Console.WriteLine(cc.x);
			//	Console.WriteLine(cc.y);

			//}			
			
			if (pc is ChildClass cc)
			{ 
				
				Console.WriteLine(cc.x);
				Console.WriteLine(cc.y);
			}
			

			Console.ReadKey();
		}
	}
}