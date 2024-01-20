namespace WareHouse
{
	public partial class Product
	{
		//private field
		private double _cost;

		//public properties
		public double Cost
		{
			get { return _cost; }
			set { _cost = value; }
		}

		//public method to call partial method
		public void CallGetTax()
		{
			GetTax();
		}
	}
}