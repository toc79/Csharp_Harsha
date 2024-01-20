class PaternPrinting
{
	static void Main()
	{
		//int j = 1;
		for (int j = 1; j <= 8; j++)
		{
			if (j <= 3 || j == 8)
			{
				for (int i = 1; i <= 10; i++)
				{
					if (i != 5 && i != 6)
					{
						System.Console.Write(i);
						System.Console.Write(" ");
					}
				}
				System.Console.WriteLine();
				continue;
			}
			else
			{
				for (int i = 10; i > 0; i--)
				{
					if (j == 6 && i == 2)
					{
						break;
					}
					System.Console.Write(i);
					System.Console.Write(" ");
				}

				System.Console.WriteLine();
				continue;
			}
			
		}
		System.Console.ReadKey();
	}
}