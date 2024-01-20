class Sample
{
	static void Main()
	{
		Product.TotalNoProduct++;

		const string developerName = "tomislav";

		//create object
		Product product1, product2, product3;

		product1 = new Product();
		//Product.TotalNoProduct++;
		product2 = new Product();
		Product.TotalNoProduct++;
		product3 = new Product();
		Product.TotalNoProduct++;

		//initalize fields
		product1.productID = 1001;
		product1.productName = "Mobile";
		product1.cost = 20000;
		product1.quantityStock = 1200;
		product2.productID = 1003;
		product2.productName = "Laptop";
		product2.cost = 45000;
		product2.quantityStock = 3400;
		product3.productID = 1003;
		product3.productName = "Speakers";
		product3.cost = 36000;
		product3.quantityStock = 800;

		//get value from fields
		System.Console.WriteLine(developerName);

		System.Console.WriteLine("Product1:");
		System.Console.WriteLine("Product ID: " + product1.productID);
		System.Console.WriteLine("Product Name: " + product1.productName);
		System.Console.WriteLine("Cost: "+ product1.cost);
		System.Console.WriteLine("Quantity in Stock: " + product1.quantityStock);
		System.Console.WriteLine("Date of Purchase: " + product1.dateOfPurchase);

		System.Console.WriteLine("\nProduct2:");
		System.Console.WriteLine("Product ID: " + product2.productID);
		System.Console.WriteLine("Product Name: " + product2.productName);
		System.Console.WriteLine("Cost: " + product2.cost);
		System.Console.WriteLine("Quantity in Stock: " + product2.quantityStock);
		System.Console.WriteLine("Date of Purchase: " + product2.dateOfPurchase);

		System.Console.WriteLine("\nProduct3:");
		System.Console.WriteLine("Product ID: " + product3.productID);
		System.Console.WriteLine("Product Name: " + product3.productName);
		System.Console.WriteLine("Cost: " + product3.cost);
		System.Console.WriteLine("Quantity in Stock: " + product3.quantityStock);
		System.Console.WriteLine("Date of Purchase: " + product3.dateOfPurchase);
		//System.Console.ReadKey();

		int totalQuantity = product1.quantityStock+product2.quantityStock + product3.quantityStock;
		System.Console.WriteLine("Total Quantity: " + totalQuantity);
		System.Console.WriteLine("Total no. of products: " + Product.TotalNoProduct);
		System.Console.WriteLine("Category of product: " + Product.CategoryName);

		System.Console.ReadKey();
	}
}

////child class in other assembly
//public class InternationalProduct : Product
//{
//	public void Method1()
//	{
//		//In child classes you does not have to create an object 
//		//productID = 1; // private field is not accessible
//		productName = "abc"; // protected field is accessible in child classes other assembly
//		cost = 1;
//	}
//}

////other class in the other assembly
//public class OtherClass2
//{
//	public void Method1()
//	{
//		//productID = 1 //not valid

//		//create object
//		Product product = new Product();
//		//product.productID = 1; // private field is not accessible
//		//product.productName = "abc"; // protected field is not accessible
//		product.cost = 1;
//	}
//}