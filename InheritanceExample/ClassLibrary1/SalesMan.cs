//public class SalesMan : Employee
public class SalesMan : IEmployee
{
	//field
	private string _region;

	private int _empID;
	private string _empName;
	protected string _location;

	private System.DateTime _dateOfBirth;

	//constructor of child class
	//public SalesMan(int empID, string empName, string location, string region) : base(empID, empName, location)

	//cunstructor for parent interface
	public SalesMan(int empID, string empName, string location, string region) 
	{
		this._empID = empID;
		this._empName = empName;
		this._location = location;

		this._region = region;
	}


	//it sholuld not be auto-proprerties said Harsha, but there is not error => it returns 0 so it must not be auto-propreties !!!
	public int EmpID
	{
		get
		{
			return _empID;
		}
		set
		{
			this._empID = value;
		}
	}
	public string EmpName
	{
		get
		{
			return _empName;
		}
		set
		{
			this._empName = value;
		}
	}
	public string Location
	{
		get
		{
			return _location;
		}
		set
		{
			this._location = value;
		}
	}

	public System.DateTime DateOfBirth
	{
		get
		{
			return this._dateOfBirth;
		}
		set
		{
			this._dateOfBirth = value;
		}
	}

	//method overriding the abstract methods
	//public override string GetHelthInsurianceAmount()

	//method implementation 
	public string GetHelthInsurianceAmount()
	{
		return "Additional Helth Insurance premium amount is: 500";
	}

	//properties
	public string Region
	{
		set
		{
			_region = value;
		}
		get
		{
			return _region;
		}
	}

	public long GetSalesOfTheCurrentMonth()
	{
		return 1000;
	}


	//method
	public int GetAge()
	{
		int a = System.Convert.ToInt32((System.DateTime.Now - DateOfBirth).TotalDays / 365);
		return a;
	}
}