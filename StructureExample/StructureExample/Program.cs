using static System.Console;

class Program
{
	static void Main()
	{
		//create structure instance
		Category category = new Category();

		//initilaze fields through properties
		category.CategoryID = 20;
		category.CategoryName = "General8";

		//access method
		WriteLine(category.GetCategoryNameLength());
		WriteLine(category.CategoryID);
		WriteLine(category.CategoryName);

		ReadKey();
		
	}
}