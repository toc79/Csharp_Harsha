using ClassLibrary1;
using System;

namespace ExtensionNamespace
{
	//static class for extension method
	public static class ProductExtension
	{
		//extension method for Product class
		public static double GetDiscont(this Product product)
		{
			return product.ProductCost * product.DiscontPercentage / 100;
		}
	}
}