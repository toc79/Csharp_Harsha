namespace WareHouse
{
	public partial class Product
	{
		//private field
		private int _productID;

		//public property
		public int ProductID
		{
			get { return _productID;}
			set { _productID = value; }
		}

		//declaration of partial method
		public partial double GetTax();
	}
}
