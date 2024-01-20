class Sample
{
	static void Main()
	{
		Product.SetTotalNumberOfProducts(Product.GetTotalNumberOfProducts() +1);

		const string developerName = "tomislav";

		//create object
		Product product1, product2, product3;

		product1 = new Product(); //null;//
		//Product.TotalNoProduct++;
		product2 = new Product();
		Product.SetTotalNumberOfProducts(Product.GetTotalNumberOfProducts() +1);
		product3 = new Product();
		Product.SetTotalNumberOfProducts(Product.GetTotalNumberOfProducts() +1);

		//initalize fields
		//product1.productID = 1001;
		//product1.productName = "Mobile";
		//product1.cost = 20000;
		//product1.quantityStock = 1200;
		//product2.productID = 1003;
		//product2.productName = "Laptop";
		//product2.cost = 45000;
		//product2.quantityStock = 3400;
		//product3.productID = 1003;
		//product3.productName = "Speakers";
		//product3.cost = 36000;
		//product3.quantityStock = 800;

		// metod is executing in seperat stack
		product1.SetProductID(1001);
		product1.SetProductName("Mobile");
		product1.SetCost(20000);
		product1.SetQuantityInStock(1200);
		product2.SetProductID(1003);
		product2.SetProductName("Laptop");
		product2.SetCost(45000);
		product2.SetQuantityInStock(3400);
		product3.SetProductID(1003);
		product3.SetProductName("Speakers");
		product3.SetCost(36000);
		product3.SetQuantityInStock(800);


		//product1.CalculateTax(percentage: 9.2);
		double q = 9.2;
		product1.CalculateTax(percentage: in q);
		//double p = 7.4;
		//product2.CalculateTax(ref p);
		//double p;
		//product2.CalculateTax(out p);
		//product2.CalculateTax(out double p);
		double p = 5.6;
		product2.CalculateTax(in p);
		System.Console.WriteLine("p is " + p);
		product3.CalculateTax(10000, 3.4);

		//get value from fields
		System.Console.WriteLine(developerName);

		System.Console.WriteLine("Product1:");
		System.Console.WriteLine("Product ID: " + product1.GetProductID());
		System.Console.WriteLine("Product Name: " + product1.GetProductName());
		System.Console.WriteLine("Cost: " + product1.GetCost());
		System.Console.WriteLine("Quantity in Stock: " + product1.GetQuantityInStock());
		System.Console.WriteLine("Date of Purchase: " + product1.GetDateOfPurchase());
		System.Console.WriteLine("Tax: " + product1.GetTax());


		System.Console.WriteLine("\nProduct2:");
		System.Console.WriteLine("Product ID: " + product2.GetProductID());
		System.Console.WriteLine("Product Name: " + product2.GetProductName());
		System.Console.WriteLine("Cost: " + product2.GetCost());
		System.Console.WriteLine("Quantity in Stock: " + product2.GetQuantityInStock());
		System.Console.WriteLine("Date of Purchase: " + product2.GetDateOfPurchase());
		System.Console.WriteLine("Tax: " + product2.GetTax());

		System.Console.WriteLine("\nProduct3:");
		System.Console.WriteLine("Product ID: " + product3.GetProductID());
		System.Console.WriteLine("Product Name: " + product3.GetProductName());
		System.Console.WriteLine("Cost: " + product3.GetCost());
		System.Console.WriteLine("Quantity in Stock: " + product3.GetQuantityInStock());
		System.Console.WriteLine("Date of Purchase: " + product3.GetDateOfPurchase());
		System.Console.WriteLine("Tax: " + product3.GetTax());
		//System.Console.ReadKey();

		// total Quantity 
		//int totalQuantity = product1.GetQuantityInStock() + product2.GetQuantityInStock() + product3.GetQuantityInStock();
		int totalQuantity = Product.GetTotalQuantity(product1, product2, product3);
		
		
		System.Console.WriteLine("Total Quantity: " + totalQuantity);
		System.Console.WriteLine("Total no. of products: " + Product.GetTotalNumberOfProducts());
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