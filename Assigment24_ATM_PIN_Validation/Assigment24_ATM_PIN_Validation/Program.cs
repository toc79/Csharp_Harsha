/*
Create a C# program with a class called DebitCard with a property called "Pin" with validations in the set accessor.
The Pin should be exactly 4 digits or 6 digits.
If the supplied pin is invalid, it shows error message.

Examples:
Pin = "1234"     -->  valid
Pin = "1234ef"     -->  invalid
Pin = "123456"     -->  valid
Pin = "0"     -->  invalid
Pin = "a4"     -->  invalid
*/

class Program
{
	class DebitCard
	{
		//instance field
		private string _pin = "";
		
		//property
		public string Pin
		{
			set {
				if (int.TryParse(value, out _) && (value.Length == 4 || value.Length == 6))
				{
					_pin = value;
				}
				else { _pin = ""; }
			}
			get { return _pin; }
		}
	}
	
	
	static void Main()
	{
		System.Console.Write("Enter PIN number:");
		string s;
		s = System.Console.ReadLine();

		DebitCard dc1 = new DebitCard();

		dc1.Pin = s;

		//System.Console.WriteLine(dc1.Pin);

		if (dc1.Pin == s)
		{
			System.Console.WriteLine("Entered PIN " +s +" is valid!");
		}
		else
		{
			System.Console.WriteLine("Entered PIN " + s + " is invalid!");
		}

		System.Console.ReadKey();

	}
}