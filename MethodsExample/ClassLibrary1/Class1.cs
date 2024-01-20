using System;

public class Product
{
	//fields are accessibale to all methods instance 
	//public int productID;
	//public string productName;
	//public double cost;
	//public double tax;
	//public int quantityStock;
	//public static int TotalNoProduct;
	//public const string CategoryName = "Electronics";
	//public readonly string dateOfPurchase;

	private int productID;
	private string productName;
	private double cost;
	private double tax;
	private int quantityStock;
	public static int TotalNoProduct;
	public const string CategoryName = "Electronics";
	private readonly string dateOfPurchase;

	//constructor
	public Product()
	{
		dateOfPurchase = System.DateTime.Now.ToShortDateString();
	}

	//Set method for productID
	public void SetProductID(int productID)
	{
		this.productID = productID;
	}

	//Get method
	public int GetProductID()
	{
		return productID;
	}

	//Set method for productName
	public void SetProductName(string value)
	{
		productName = value;
	}
	//Get method for productName
	public string GetProductName()
	{
		return productName;
	}

	//Set method for cost
	public void SetCost(double value)
	{
		cost = value;
	}
	//Get method for cost
	public double GetCost()
	{
		return cost;
	}

	//Set method for tax
	public void SetTax(double value)
	{
		tax = value;
	}
	//Get method for tax
	public double GetTax()
	{
		return tax;
	}

	//CalculateTax method to calculate tax
	//method
	/*cost <=20000 then tax = 10%
	 cost > 20000 then tax = 12.5%  */
	public void CalculateTax(in double percentage)
	{
		//percentage = 10.45;
		//create local variable
		double t;

		//calculate tax
		if (cost <= 20000)
		{
			t = cost * 10 / 100;
		}
		else
		{
			t = cost * percentage / 100;
		}

		tax = t;
	}

	public void CalculateTax(double cost, double percentage)
	{
		//create local variable
		double t;

		//calculate tax
		if (cost <= 50000)
		{
			t = cost * 5 / 100;
		}
		else
		{
			t = cost * percentage / 100;
		}

		tax = t;
	}

	//Set method for quantityInStock
	public void SetQuantityInStock(int value)
	{
		quantityStock = value;
	}
	//Get method for quantityInStock
	public int GetQuantityInStock()
	{
		return quantityStock;
	}

	//Get method for dateOfPurchase
	public string GetDateOfPurchase()
	{
		return dateOfPurchase;
	}

	//static method: Set method TotalNoOfProducts 
	public static void SetTotalNumberOfProducts(int value)
	{
		TotalNoProduct = value;
	}

	//static method: Get method TotalNoOfProducts 
	public static int GetTotalNumberOfProducts()
	{
		return TotalNoProduct;
	}

	//static method: Calculates Total Quantity
	public static int GetTotalQuantity(Product product1, Product product2, Product product3)
	{
		int total;
		total = product1.GetQuantityInStock() + product2.GetQuantityInStock() + product3.GetQuantityInStock();
		return total;
	}
}
