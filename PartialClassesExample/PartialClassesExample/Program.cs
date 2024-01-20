using static System.Console;
using WareHouse;

class Program
{
	static void Main()
	{
		//create object of Partial class
		Product product = new Product();

		//access property
		product.ProductID = 101;
		product.Cost = 1000;

		//access method
		product.CallGetTax();

		ReadKey();
	}
}