using System.CodeDom.Compiler;

class TypeConvestion
{
	static void Main()
	{
		byte a = 10; //Convert this value into "short" type (assign into another short type of variable)
		//short aShort = (short)a; // at quick action there is a comment Unneccesery cast 
		short aShort = a;
		System.Console.WriteLine("Byte a: " +a);
		System.Console.WriteLine("Short a: " +aShort);

		int b = 10; //Convert this value into "short" type (assign into another short type of variable)
		short bShort = (short)b;
		System.Console.WriteLine("Int b: " + b);
		System.Console.WriteLine("Short b: " + bShort);

		string c = "10,34"; //Convert this value into "double" type using Parse  
		double cDouble = double.Parse(c);

		System.Console.WriteLine("String c: " + c);
		System.Console.WriteLine("Double c: " + cDouble);

		//Also, convert the same value into "decimal" type  using TryParse
		bool cCanConvertToDecimal = decimal.TryParse(c, out decimal cDecimal);

		if (cCanConvertToDecimal == true)
		{
			System.Console.WriteLine("Decimal c: " + cDecimal);
		}
		

		decimal d = 20.3M; //Convert this value into "string" type (assign into another string type of variable) 
		string dString = System.Convert.ToString(d);

		System.Console.WriteLine("Decimal d: " + d);
		System.Console.WriteLine("String d: " + dString);

		System.Console.ReadKey();

	}
}