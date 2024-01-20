using System;
using ClassLibrary1;

namespace ValueTupleExample
{
	internal class Program
	{
		static void Main()
		{
			//create object of customer class
			Customer customer = new Customer();

			Console.WriteLine(customer.GetCustomerDetails());
			Console.WriteLine("\n");

			//get details
			(int customerID, string customerName, string email) cust = customer.GetCustomerDetails();
			
			Console.WriteLine(cust);


			Console.WriteLine(cust.customerID);
			Console.WriteLine(cust.customerName);
			Console.WriteLine(cust.email);
			Console.WriteLine("\n");


			//deconstructing 
			(int customerID, string customerName, string email) = customer.GetCustomerDetails();

			Console.WriteLine("deconstructing");
			Console.WriteLine(customerID);
			Console.WriteLine(customerName);
			Console.WriteLine(email);
			Console.WriteLine("\n");

			//discard
			(int customerID2, _, string email2) = customer.GetCustomerDetails();

			Console.WriteLine("discard");
			Console.WriteLine(customerID2);
			//Console.WriteLine(customerName);
			Console.WriteLine(email2);



			Console.ReadKey();
		}
	}
}
