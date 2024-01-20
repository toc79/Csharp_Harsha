namespace WareHouse
{

	public partial class Product
	{
		//public method
		//public double GetTax()

		partial void GetTax()
		{
			double tax = Cost * 10 / 100;
			//return tax;
			System.Console.WriteLine(tax);
		}
	}
}