using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace BinarySerializationExample
{
	[Serializable]
	public class Country
	{
		public short CountryID { get; set; }
		public string CountryName { get; set; }
		public long Population { get; set; }
		public string Region { get; set; }
	}

	internal class Program
	{
		static void Main()
		{

			//Code for serialization
			//create object
			Country country = new Country() { CountryID = 1, CountryName = "Russia", Population = 145934000, Region = "Eastern Europe" };

			//create filestream
			string filePath = @"c:\practice\russia.txt";
			FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write);

			//create BinaryFormatter
			BinaryFormatter binaryFormatter = new BinaryFormatter();
			binaryFormatter.Serialize(fileStream, country);
			fileStream.Close();
			Console.WriteLine("Serialized");


			//Code for deserialization
			FileStream fileStream2 = new FileStream(filePath, FileMode.Open, FileAccess.Read);
			//BinaryFormatter binaryFormatter2 = new BinaryFormatter();
			//binaryFormatter2.Deserialize(fileStream2);
			Country countryFromFile = (Country)binaryFormatter.Deserialize(fileStream2);
			Console.WriteLine(countryFromFile.CountryName);

			Console.ReadKey();
		}
	}
}
