//parent class
//public class Employee

//parent class & absrtract class 
//public abstract class Employee

//interface
public interface IEmployee : IPerson
{
	//fields
	//private int _empID;
	//private string _empName;
	//protected string _location;

	////constructor of parent class
	//public Employee(int empId, string empName, string location)
	//{
	//	this._empID = empId;
	//	this._empName = empName;
	//	this._location = location;	
	//}

	//method
	//public virtual string GetHelthInsurianceAmount()
	//{
	//	return "Helth Insuriance amount is: " + 500;
	//}	
	//public abstract string GetHelthInsurianceAmount();
	string GetHelthInsurianceAmount();

	//auto-proprerties
	int EmpID { get; set; }
	string EmpName { get; set; }
	string Location {  get; set; } 

	
	//properties
	//public int EmpID
	//{
	//	set
	//	{
	//		_empID = value;
	//	}
	//	get
	//	{
	//		return _empID;
	//	}
	//}

	//public string EmpName
	//{
	//	set
	//	{
	//		_empName = value;
	//	}
	//	get
	//	{
	//		return _empName;
	//	}
	//}

	//public string Location
	//{
	//	set
	//	{
	//		_location = value;
	//	}
	//	get
	//	{
	//		return _location;
	//	}
	//}



}