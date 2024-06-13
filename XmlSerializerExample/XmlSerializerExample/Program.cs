using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace XmlSerializerExample
{
	[Serializable]
	public class Continent
	{
		public string ContinentName { get; set;}
		public List<Country> Countries { get; set;}
	}
	
	[Serializable]
	public class Country
	{
		public int CountryID { get; set; }
		public string CountryName { get; set; }
	}
	class Program
	{
		static void Main()
		{
			//create object
			List<Continent> continents = new List<Continent>();
			continents.Add(new Continent()
			{
				ContinentName = "Africa",
				Countries = new List<Country>() 
					{ new Country() {CountryID = 1, CountryName = "Sudan"},
					 new Country() {CountryID = 2, CountryName = "Libiya"},
					 new Country() {CountryID = 3, CountryName = "South Africa"}
					}			
			});
			continents.Add(new Continent()
			{
				ContinentName = "Asia",
				Countries = new List<Country>()
					{ new Country() {CountryID = 4, CountryName = "Russia"},
					 new Country() {CountryID = 5, CountryName = "China"},
					 new Country() {CountryID = 6, CountryName = "India"}
					}
			});

			continents.Add(new Continent()
			{
				ContinentName = "Europe",
				Countries = new List<Country>()
					{ new Country() {CountryID = 7, CountryName = "Russia"},
					 new Country() {CountryID = 8, CountryName = "Ukraine"},
					 new Country() {CountryID = 9, CountryName = "France"}
					}
			});

			continents.Add(new Continent()
			{
				ContinentName = "North America",
				Countries = new List<Country>()
					{ new Country() {CountryID = 10, CountryName = "Canada"},
					 new Country() {CountryID = 11, CountryName = "United States"},
					 new Country() {CountryID = 12, CountryName = "Mexico"}
					}
			});

			continents.Add(new Continent()
			{
				ContinentName = "South America",
				Countries = new List<Country>()
					{ new Country() {CountryID = 13, CountryName = "Brazil"},
					 new Country() {CountryID = 14, CountryName = "Argentina"},
					 new Country() {CountryID = 15, CountryName = "Peru"}
					}
			});

			Country country = new Country() {CountryID = 1, CountryName = "Untided States" };
			
			//create object of XmlSerializer
			XmlSerializer xmlSerializer = new XmlSerializer(typeof(Country));
			
			XmlSerializer xmlSerializerContinents = new XmlSerializer(typeof(List<Continent>));

			string filePath = @"c:\practice\country.xml";
			string filePathSW = @"c:\practice\country_stream_writer.xml";
			string filePathContinents = @"c:\practice\continents.xml";

			//in class it is used FileStream
			FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write);

			StreamWriter streamWriter = new StreamWriter(filePathSW);

			StreamWriter streamWriterContinents = new StreamWriter(filePathContinents);

			//serialize
			xmlSerializer.Serialize(fileStream, country);
			fileStream.Close();

			Console.WriteLine("country.xml created");

			//serialize stream writer
			xmlSerializer.Serialize(streamWriter, country);
			streamWriter.Close();
			Console.WriteLine("country_stream_writer.xml created");


			//serializable continents
			xmlSerializerContinents.Serialize(streamWriterContinents, continents);
			streamWriterContinents.Close();
			Console.WriteLine("continates.xml created");


			//Deserialize

			FileStream fileStreamDeserialize = new FileStream(filePathContinents, FileMode.Open, FileAccess.Read);
			List<Continent> continents_from_file =  xmlSerializerContinents.Deserialize(fileStreamDeserialize) as List<Continent>;
			Console.WriteLine("\ncontinents.xml created");

			foreach(Continent cont in continents_from_file)
			{
				Console.WriteLine("\n" +cont.ContinentName);

				foreach(Country country_from_file in cont.Countries)
				{
					Console.Write(country_from_file.CountryName +", ");
				}
			}


			System.Console.ReadKey();
		}
	}
}
