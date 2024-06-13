using System;


namespace NullReferenceExample
{
	public class BankAccount
	{
		public int AccountNumber { get; set; }
		public string AccountHolderName { get; set; }
		public double CurrentBalance { get; set; }

	}

	public class FundsTransfer
	{
		public void Transfer(BankAccount sourceAccount, BankAccount destinationAccount, double amount)
		{
			try
			{
				sourceAccount.CurrentBalance -= amount;
				destinationAccount.CurrentBalance += amount;
		}
			catch (NullReferenceException ex) {
				Console.WriteLine("Catch inside Transfer MEthod " +ex.Message);
				Console.WriteLine("The destination account is null");
				throw; //throwing exception to outer calling portion (Main method) of the code to stop transfor from Bob's accounts
			}
}
	}
	
	internal class Program
	{
		static void Main()
		{
			try {			
				BankAccount bobBankAccount = new BankAccount() { AccountNumber = 101, AccountHolderName = "Bob", CurrentBalance = 10000 };
				BankAccount aliceBankAccount = new BankAccount() { AccountNumber = 102, AccountHolderName = "Alice", CurrentBalance = 5000 };

				FundsTransfer fundsTransfer = new FundsTransfer();
				fundsTransfer.Transfer(bobBankAccount, aliceBankAccount, 1000);

				Console.WriteLine("Funds transfered");
				Console.WriteLine("Bob balance: " + bobBankAccount.CurrentBalance);
				Console.WriteLine("Alice balance: " + aliceBankAccount.CurrentBalance);


				BankAccount stevenBankAccount = null;
				fundsTransfer.Transfer(bobBankAccount, stevenBankAccount, 1000);
				Console.WriteLine("Funds transfered Steven example");
				Console.WriteLine("Bob balance: " + bobBankAccount.CurrentBalance);
				Console.WriteLine("Steven balance: " + stevenBankAccount.CurrentBalance);

			} catch (NullReferenceException ex) {
				Console.WriteLine(ex.Message);
				Console.WriteLine("The destination account is null");
			}

			Console.ReadKey();
		}
	}
}
