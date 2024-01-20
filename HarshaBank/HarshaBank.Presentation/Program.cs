class Program
{
	static void Main()
	{
		//display title 
		System.Console.WriteLine("**************Harsha Bank**************");
		System.Console.WriteLine("::Login page::");

		//declare variables to store username and password;
		string userName = null, password = null;

		//read userName from keyboard
		System.Console.Write("Username:");
		userName = System.Console.ReadLine();
		
		if (userName != "")
		{
			//read password from keyboard
			System.Console.Write("Password:");
			password = System.Console.ReadLine();
		}

		if (userName == "system" && password == "manager")
		{
			//daclare variable to store menu choice
			int mainMenuChoice = -1;

			do
			{
				System.Console.WriteLine("\n:::Main menu:::");
				System.Console.WriteLine("1. Customers");
				System.Console.WriteLine("2. Accounts");
				System.Console.WriteLine("3. Founds Transfer");
				System.Console.WriteLine("4. Founds Transfer Statmenr");
				System.Console.WriteLine("5. Account Statment");
				System.Console.WriteLine("0. Exit");

				System.Console.WriteLine("Enter choice:");
				mainMenuChoice = int.Parse(System.Console.ReadLine());

				//switc-case tp check menu choice 
				switch (mainMenuChoice)
				{
					case 1: //TODO: Display customers menu 
						CustomerMenu();
						break;
					case 2: //TODO: Display accounts menu 
						AccountsMenu();
						break;
					case 3: //TODO: Display founds transfer menu 
						break;
					case 4: //TODO: Display founds transfer statment menu 
						break;
					case 5: //TODO: Display Accounts statment menu 
						break;
				}
			} while (mainMenuChoice != 0);
		}
		else
		{
			System.Console.WriteLine("Invalid username or password!");
		}

		//abour to exit
		System.Console.WriteLine("Thank you! Visit again.");
		System.Console.ReadKey();
	}

	static void CustomerMenu()
	{
		//variable to store customer menu choice
		int customerMenuChoice = -1;

		//do-while loop starts
		do
		{
			//print customers menu
			System.Console.WriteLine("\n:::Customers menu:::");
			System.Console.WriteLine("1. Add Customer");
			System.Console.WriteLine("2. Delete Customer");
			System.Console.WriteLine("3. Update Customer");
			System.Console.WriteLine("4. View Customers");
			System.Console.WriteLine("0. Back to main menu");

			//accept customers manu choice
			System.Console.Write("Enter choice:");
			customerMenuChoice = System.Convert.ToInt32(System.Console.ReadLine());

		} while (customerMenuChoice != 0);
	}

	static void AccountsMenu ()
	{
		//variable to store accounts menu choice
		int accountsMenuChoice = -1;

		//do-while loop starts
		do
		{
			//print accounts menu
			System.Console.WriteLine("\n:::Accounts menu:::");
			System.Console.WriteLine("1. Add Account");
			System.Console.WriteLine("2. Delete Account");
			System.Console.WriteLine("3. Update Account");
			System.Console.WriteLine("4. View Accounts");
			System.Console.WriteLine("0. Back to main menu");

			//accept customers manu choice
			System.Console.Write("Enter choice:");
			accountsMenuChoice = System.Convert.ToInt32(System.Console.ReadLine());

		} while (accountsMenuChoice != 0);
	}
}