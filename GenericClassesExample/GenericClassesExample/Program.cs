using static System.Console;
class Program
{
	static void Main()
	{
		//crate object of gemeric class
		User<int, int> user1 = new User<int, int>();
		User<bool, string> user2 = new User<bool, string>();

		//set value into generic field
		user1.RegistrationStatus = 1234;
		user2.RegistrationStatus = false;

		user1.Age = 22;
		user2.Age = "35 - 40";

		WriteLine(user1.RegistrationStatus);
		WriteLine(user2.RegistrationStatus);
		
		WriteLine(user1.Age);
		WriteLine(user2.Age);

		ReadKey();
	}
}