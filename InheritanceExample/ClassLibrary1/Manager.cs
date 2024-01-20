//public class Manager : Employee
public class Manager : IEmployee
{
	//field
	private string _departmentName;

	private int _empID;
	private string _empName;
	private string _location;

	private System.DateTime _dateOfBirth;

	//constructor of child class
	//public Manager(int empID, string empName, string location, string departmentName) : base(empID, empName, location)

	//constructor for parent interface
	public Manager(int empID, string empName, string location, string departmentName)
	{
		this._departmentName = departmentName;

		this._empID = empID;
		this._empName = empName;
		this._location = location;
	}

	//it sholuld not be auto-proprerties said Harsha, but there is not error => it returns 0 so it must not be auto-propreties !!!
	public int EmpID {
		get
		{
			return _empID;
		}
		set
		{
			this._empID = value;
		}
	}
	public string EmpName {
		get
		{
			return _empName;
		}
		set
		{
			this._empName = value;
		}
	}
	public string Location {
		get
		{
			return _location;
		}
		set
		{
			this._location = value;
		}
	}

	public System.DateTime DateOfBirth {
		get
		{
			return this._dateOfBirth;
		}
		set
		{
			this._dateOfBirth = value;
		}
	}


	//method
	//public new string GetHelthInsurianceAmount()
	//public override string GetHelthInsurianceAmount()
	//public sealed override string GetHelthInsurianceAmount()
	//{
	//	System.Console.WriteLine(base.GetHelthInsurianceAmount());
	//	return "Helth Insuriance premium amount is: 1000" ;
	//}

	//method overriding the abstract methods
	//public override string GetHelthInsurianceAmount()
	//method implementation of the instance methods 
	public string GetHelthInsurianceAmount()
	{
		return "Helth Insuriance premium amount is: 1000" ;
	}
	
	//property 
	public string DepartmentName
	{
		set
		{
			_departmentName = value;
		}
		get
		{
			return _departmentName;
		}
	}

	public long GetTotalSalesOfTheYear()
	{
		return 10000;
	}

	//method
	public string GetFullDepartmentName()
	{
		//return DepartmentName + " at " + base._location;
		return DepartmentName + " at " + _location;
	}

	//method
	public int GetAge()
	{
		int a = System.Convert.ToInt32((System.DateTime.Now - DateOfBirth).TotalDays / 365);
		return a;
	}

}

public class BranchManager : Manager
{
	//constructor of child class
	public BranchManager(int empID, string empName, string location, string departmentName) : base(empID, empName, location, departmentName)
	{
		
	}

	//method overriding of virtual methods
	//public override string GetHelthInsurianceAmount()
	//{

	//}

}