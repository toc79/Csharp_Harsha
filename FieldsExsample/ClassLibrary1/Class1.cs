public class Product
{
	//fields
	public int productID;
	public string productName;
	public double cost;
	public int quantityStock;
	public static int TotalNoProduct;
	public const string CategoryName = "Electronics";
	public readonly string dateOfPurchase;

	//constructor
	public Product ()
	{
		dateOfPurchase = System.DateTime.Now.ToShortDateString();
	}

} 

////Child class at the same assembly 
//public class DomesticProduct : Product
//{
//	public void Method1()
//	{
//		//productID = 1 //not valid
//		productName = "abc";
//	}
//}

////Other class at the same assembly
//public class OtherClass
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

