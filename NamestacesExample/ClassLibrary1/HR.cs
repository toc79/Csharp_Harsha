namespace HR
{
	namespace Mgr
	{
		//inteface that represents a manager, which inherits from IEmployee
		public interface IManager : IEmployee
		{

		}

		//class that represent a manager, which inherits from IManager
		public class Manager : IManager
		{

		}

		//class that represent an assistent manager, which inherits from IExecutive
		public class AsstManager : IManager
		{

		}
		
		//class that represent a executive, which inherits from IExecutive
		public class Executive : IManager
		{

		}
	}
	
	//interface that represent an employee in the organization 
	public interface IEmployee
	{

	}



	//interface that represent an executive, which inferits from IEmployee
	public interface IExecutive : IEmployee
	{

	}

	




}