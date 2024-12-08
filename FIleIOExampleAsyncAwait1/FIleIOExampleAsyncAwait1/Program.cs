using System;
using System.IO;
using System.Threading.Tasks;

class FileWriter
{
	public async Task WriteFile(string fileName, string data)
	{
		//StreamWriter writer = new StreamWriter(fileName);
		//Task writerTask = writer.WriteAsync(data);
		//await writerTask;
		//shorthand for above, simplified version

		using (StreamWriter writer = new StreamWriter(fileName)) 
		{ 
			await writer.WriteAsync(data); 
		}
		
		//writer.Close(); insted of Close, you can use using block statment 
	}
}

class FileReader
{
	public async Task<string> ReadFile(string fileName)
	{
		//StreamReader reader = new StreamReader(fileName);
		//	//Task<string> readerTask = reader.ReadToEndAsync();
		//	//string content =  reader.Result; // automatski vraća Result sadržaj
		//	//shorthand for above, simplified version
		//string content = await reader.ReadToEndAsync();
		
		//reader.Close();
		//return content;

		//or simplified
		using (StreamReader reader = new StreamReader(fileName))
		{
			string content = await reader.ReadToEndAsync();
			return content;
		}


	}
}

class Program
{
	public async static Task Main()
	{
		//Initialize
		string fileName = @"c:\practice\india.txt";
		FileWriter fileWriter = new FileWriter();
		FileReader fileReader = new FileReader();

		//Write date to file asynchronously
		//Task writerTaskFromMain = fileWriter.WriteFile(fileName, "India is the most populos country by 2023");
		//writerTaskFromMain.Wait(); //Block until the write operation is completed
		//await writerTaskFromMain; // doesnt block. It block curent task, but without blocking the current thread
		
		//shorthand for above, simplified version
		await fileWriter.WriteFile(fileName, "India is the most populos country by 2023");


		//Read data from the file asynchronously
		//Task<string> readerTask = fileReader.ReadFile(fileName);
		//readerTask.Wait(); //Block the current thread until the read operation is completed.
		//await readerTask;
		//shorthand for above, simplified version
		string content = await fileReader.ReadFile(fileName);

		Console.WriteLine("File read.");
		Console.WriteLine($"\nFile content: {content}");

		Console.ReadKey();
	}
}