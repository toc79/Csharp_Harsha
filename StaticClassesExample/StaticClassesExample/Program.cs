using System;

class Program
{
	static void Main()
	{
		//create object of static class
		Console.WriteLine(Country.CountryName);
		Console.WriteLine(Country.NoOfStates);
		Console.WriteLine(Country.GetNumberOfUnionTerritories());
		Console.ReadKey();
	}
}