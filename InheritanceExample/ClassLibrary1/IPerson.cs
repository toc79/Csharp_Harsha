public interface IPerson
{
	//auto-properties
	System.DateTime DateOfBirth { get; set; }

	int GetAge();
}