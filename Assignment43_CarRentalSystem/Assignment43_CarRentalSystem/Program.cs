using System;
using System.Collections.Concurrent;
using System.Linq;

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

		public int CarID { get; set; }

		//I have not created constructor but it works anyway. Example of constructor 
		//public Car(int id, string make, string model, int rentalPrice, bool isAvailable)
		//{
		//	Id = id;
		//	Make = make;
		//	Model = model;
		//	RentalPrice = rentalPrice;
		//	IsAvailable = isAvailable;
		//}


		//method for renting the car
		public bool Rent()
		{
			if (rented == false)
			{
				rented = true;
				Console.WriteLine("Rented the " + make + " " + model + " for $" + rentalPrice + " / day.");
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
			if (rented == true)
			{
				rented = false;
				Console.WriteLine("Returned the " + make + " " + model + ".");
				return true;
			}
			else
			{
				Console.WriteLine("Selected car " + model + " can not be returned because it is not rented!");
				return false;
			}
		}

		//method for printing info
		public void PrintInfo()
		{
			Console.WriteLine(CarID +". " + model + "(Rental price: " + rentalPrice + "/day) - " + (rented ? "Rented" : "Available"));
		}
	}

	class MenuChoices
	{
		public string ChoiceID { get; set;}
		public string Choice { get; set; }
	}

	class Program
	{
		static void Main()
		{
			Console.WriteLine("Welcome to the car rental system!");

			//creating Car object 1  
			//Car[] myCars = new Car[] { 
			//	new Car() { Make = "Toyota", Model = "Corola", RentalPrice = 50, Rented = false},
			//	new Car() { Make = "Honda", Model = "Civic", RentalPrice = 60, Rented = false},
			//	new Car() { Make = "Ford", Model = "Mustang", RentalPrice = 80, Rented = false},
			//};
			
			//creating Car object 2
			Car[] myCars = new Car[] { 
				new Car() {CarID = 1, Make = "Toyota", Model = "Corola", RentalPrice = 50, Rented = false},
				new Car() {CarID = 2, Make = "Honda", Model = "Civic", RentalPrice = 60, Rented = false},
				new Car() {CarID = 3, Make = "Ford", Model = "Mustang", RentalPrice = 80, Rented = false},
			};

			void PrintInfoAll()
			{
				foreach (Car item in myCars)
				{
					item.PrintInfo();
				}
			}

			// create array of menu choices 1
			//string[] menu = new string[4] { "Rent a car", "Return a car", "View available cars", "Exit" };

			// create array of menu choices 2
			string[] menu = new string[5] { "", "Rent a car", "Return a car", "View available cars", "Exit" };

			// create array of menu choices 3
			//MenuChoices[] menu2 = new MenuChoices[] {
			//		new MenuChoices() {ChoiceID = "1", Choice = "Rent a car"},
			//		new MenuChoices() {ChoiceID = "2", Choice = "Return a car"},
			//		new MenuChoices() {ChoiceID = "3", Choice = "View available cars"},
			//		new MenuChoices() {ChoiceID = "4", Choice = "Exit"}
			//	};

			string enteredChoice = "";
			//int no_choice = 0;

			do
			{
				Console.WriteLine("\nMenu:");
				// menu 1
				//for (int i = 0; i < menu.Length; i++)
				//{
				//	Console.WriteLine(i + 1 + ". " + menu[i]);
				//}

				// menu 2
				for (int i = 1; i < menu.Length; i++)
				{
					Console.WriteLine(i + ". " + menu[i]);
				}

				//menu 3
				//foreach (MenuChoices item in menu2)
				//{
				//	Console.WriteLine(item.ChoiceID + ". " + item.Choice);
				//}


				Console.Write("Please enter your choice: ");
				//bool choiceValid = int.TryParse(Console.ReadLine(), out int no_choice_out);
				//no_choice = no_choice_out;
				enteredChoice = Console.ReadLine();

				//Console.WriteLine("\n" + menu[int.Parse(enteredChoice)]); RUNTIME ERROR WHEN CHOSING 5
				//PrintInfoAll();

				switch (enteredChoice)
				{
					case "1":
						Console.WriteLine("\n" + menu[int.Parse(enteredChoice)]);
						PrintInfoAll();
						Console.Write("Please enter the ID of the car you want to rent: ");
						enteredChoice = Console.ReadLine();
						if (enteredChoice =="1" || enteredChoice == "2"  || enteredChoice == "3" )
						{
							foreach (Car item in myCars)
							{
								if (item.CarID == int.Parse(enteredChoice))
								{
									item.Rent();
								}
							}
						} else
							Console.WriteLine("\nEntered choice does not exists!");
						break;
					case "2":
						Console.WriteLine("\n" + menu[int.Parse(enteredChoice)]);
						PrintInfoAll();
						Console.Write("Please enter the ID of the car you want to return: ");
						enteredChoice = Console.ReadLine();
						if (enteredChoice == "1" || enteredChoice == "2" || enteredChoice == "3")
						{
							foreach (Car item in myCars)
							{
								if (item.CarID == int.Parse(enteredChoice))
								{
									item.Return();
								}
							}
						}
						else
							Console.WriteLine("\nEntered choice does not exists!");
						break;
					case "3":
						Console.WriteLine("\n" + menu[int.Parse(enteredChoice)]);
						PrintInfoAll();
						break;
					case "4":
						break;
					default:
						Console.WriteLine("\nEntered choice does not exists!");
						break;

				}
			} while (enteredChoice != "4");

			Console.WriteLine("Thank you for using the car rental system!");
			Console.ReadKey();
			
		}
	}
}