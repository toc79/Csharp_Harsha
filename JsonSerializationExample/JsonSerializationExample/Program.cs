﻿using System;
using System.IO;
using System.Web.Configuration;
using System.Web.Script.Serialization;

namespace JsonSerializationExample
{
	internal class Program
	{
		[Serializable]
		public class Customer
		{
			public int CustomerId { get; set; }
			public string CustomerName { get; set; }
			public int Age { get; set; }
		}

		static void Main()
		{
			//create object
			Customer customer = new Customer() { CustomerId = 1, CustomerName = "Nancy", Age = 20 };

			//create object of JavaScriptSerializer
			JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
			string filePath = @"c:\practice\customer.txt";
			StreamWriter streamWriter = new StreamWriter(filePath);
			
			//Serialize
			string json = javaScriptSerializer.Serialize(customer);
			streamWriter.WriteLine(json);
			streamWriter.Close();
			Console.WriteLine(json);
			Console.WriteLine("Serialized");


			//Deserialize
			StreamReader streamReader = new StreamReader(filePath);
			//Customer customerFromFile = (Customer)javaScriptSerializer.Deserialize(streamReader.ReadToEnd(), typeof(Customer));
			Customer customerFromFile = javaScriptSerializer.Deserialize(streamReader.ReadToEnd(), typeof(Customer)) as Customer;


			Console.ReadKey();
		}
	}
}
