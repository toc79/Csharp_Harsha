using System;
using System.Runtime.CompilerServices;

namespace Assignment43_CarRentalSystem
{
	class Car
	{
		//private fields
		private string make;
		private string model;
		private double rentalPrice;
		private bool rented;

		//properties
		public string Make { get { return make; } set { make = value; } }
		public string Model { get { return model; } set { model = value; } }
		public double RentalPrice { get { return rentalPrice; } set { rentalPrice = value; } }
		public bool Rented { get { return rented; } set { rented = value; } }

		//method for renting the car
		public bool Rent()
		{
			if (rented == false)
			{
				rented = true;
				return true;
			} 
			else
			{
				Console.WriteLine("Sorry, the selected car is not available for rent.");
				return false;
			}
		}

		//method for returnig the car
		public bool Return()
		{
			if(rented == true)
			{
				rented = false;
				return true;
			}
			else
			{
				Console.WriteLine("Selected car " + model + "can not be returned because it is not rented!");
				return false;
			}
		}

		//method for printing info
		public void PrintInfo()
		{
			Console.WriteLine(model + "(Rental price: " + rentalPrice + "/day) - " + (rented ? "Rented" : "Available"));
		}
	}

	class Program
	{
		static void Main()
		{
			int? no_choice = null;

			Car[] myCars = new Car[] { 
				new Car() { Make = "Toyota", Model = "Corola", RentalPrice = 50, Rented = false},
				new Car() { Make = "Honda", Model = "Civic", RentalPrice = 60, Rented = false},
				new Car() { Make = "Ford", Model = "Mustang", RentalPrice = 80, Rented = false},
			};

			do
			{
				Menu();
			}
			while (no_choice.HasValue && no_choice != 4);
				
			

			Console.ReadKey();


			
			void Menu()
			{

				//Console.WriteLine("Menu:\r\n1. Rent a car\r\n2. Return a car\r\n3. View available cars\r\n4. Exit\r\n\nPlease enter your choice:");
				
				// create array of menu choices
				string[] menu = new string[4] {"Rent a car", "Return a car", "View available cars", "Exit" };
								
				Console.WriteLine("Menu:");
				for(int i = 0; i<menu.Length; i++)
				{
					Console.WriteLine(i + 1 + ". " + menu[i]);
				}
				
				

				Console.Write("Please enter your choice:");
				string choice = "";
				//choice = Console.ReadLine();


				if (choice == "1" || choice == "2" || choice == "3" || choice == "4")
				{
					no_choice = int.Parse(choice);
				}
				else
				{
					Console.WriteLine("Entered choice does not exists!");
					no_choice = 0;
				}

				Console.WriteLine(choice);

			}
		}
	}
}
