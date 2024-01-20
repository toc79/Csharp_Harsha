public class Employee
{
	//fields
	public int emplID;
	public string empName;
	public int salaryPerHour; // or float maybe 
	public int noOfWorkingHours;
	public int netSalary;
	public static string OrganizationName;
	public const string TypeOfEmployee = "Contract Based";
	public readonly string departmentName;

	//constructor
	public Employee()
	{
		departmentName = "Finance Department";
	}
}