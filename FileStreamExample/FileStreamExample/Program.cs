using System;
using System.IO;
using System.Text;


namespace FileStreamExample
{
	internal class Program
	{
		static void Main()
		{
			string filePath = @"c:\practice\dog.txt";

			FileInfo fileInfo = new FileInfo(filePath);

			//FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write);  
			//FileStream fileStream = File.Create(filePath);  
			//FileStream fileStream = File.Open(filePath, FileMode.Create, FileAccess.Read); //both statments are equal 
			//FileStream fileStream = File.OpenWrite(filePath); // works in the same way as above statments
			//FileStream fileStream = fileInfo.Create();
			FileStream fileStream = fileInfo.Open(FileMode.Create, FileAccess.Write);
			//FileStream fileStream = fileInfo.Open(FileMode.CreateNew, FileAccess.Write);
			//FileStream fileStream = fileInfo.OpenWrite();

			//how many ways to create FileStream class

			//create content
			string content = "Dog is one of the domestic animal.";

			//byte[] bytes = System.Text.Encoding.ASCII.GetBytes(content);
			byte[] bytes = Encoding.UTF8.GetBytes(content);

			//write
			fileStream.Write(bytes, 0, bytes.Length);

			string content2 = "other text here";
			byte[] bytes2 = Encoding.UTF8.GetBytes(content2);
			//write again
			fileStream.Write(bytes2, 0, bytes2.Length);

			
			fileStream.Close();

			Console.WriteLine("dog.txt created");

			//File reading
			//FileStream fileStream2 = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Read);
			//FileStream fileStream2 = File.Open(filePath, FileMode.OpenOrCreate, FileAccess.Read);
			//FileStream fileStream2 = File.OpenRead(filePath);
			//FileStream fileStream2 = fileInfo.Open(FileMode.OpenOrCreate, FileAccess.Read);
			FileStream fileStream2 = fileInfo.OpenRead();

			//create empty byte
			byte[] bytes3 = new byte[fileStream2.Length];
			fileStream2.Read(bytes3, 0, (int)fileStream2.Length); //bytes3.Length or fileStream2.Length

			//convert byte[] to string
			string content3 = Encoding.UTF8.GetString(bytes3);
			Console.WriteLine("\nFile read. File content is: ");
			Console.WriteLine(content3);

			fileStream2.Close();

			Console.ReadKey();
		}

	}
}
