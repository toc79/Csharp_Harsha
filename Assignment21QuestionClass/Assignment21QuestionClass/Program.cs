/*There is a quiz application, where it contains loads of MCQs (Multiple Choice Questions).
Each question would have two, three or four options - like option A, B, C, D.
Eg:
Question: What is the capital of the USA?
Option A: London
Option B: New York
Option C: Washington, D.C.
Option D: San Diego
Correct Answer Letter: 'C'

The 'Question' class contains the following members:
A public field to store questionText(string)
A public field to store optionA(string)
A public field to store optionB(string)
A public field to store optionC(string)
A public field to store optionD(string)
A public field to store correctAnswerLetter(char). It should be either 'A' , 'B', 'C' or 'D'. Its value can't be any other than these.
A private static field to store defaultCorrectAnswerLetter. Eg: 'X'.Its value can be any other letter. If no value is initialized into correctAnswerLetter field, then assign it to the value of defaultCorrectAnswerLetter i.e correctAnswerLetter=defaultCorrectAnswerLetter.
A public constructor that receives no parameters. It initializes questionText, optionA, optionB, optionC, optionD as null. Initialize correctAnswerLetter to the value of static field 'defaultCorrectAnswerLetter'.
A public constructor that receives questionText as parameter and initializes questionText. Also, initialize optionA, optionB, optionC, optionD as null. Initialize correctAnswerLetter to the value of static field 'defaultCorrectAnswerLetter'.
A public constructor that initializes questionText, optionA, optionB, optionC, optionD and correctAnswerText; receive all values as parameters.
A public method that returns true, if at least the question has two options; that means, at least two options are not null. For example, the options A, B, C are filled with some text; but the option D is null. So there are three options in the question. Our requirement is, at least there should be two options. So this question is 'valid'. So the method should return true in this case.

Create objects for 'Question' class as follows, in Main method:
Create the first object of Question class and pass no arguments to the constructor.
Create the second object of Question class and pass value for questionText only to the constructor.
Create the third object of Question class and pass values for questionText, optionA, optionB, optionC, optionD and correctAnswerLetter to the constructor.
Create the fourth object for Question class and pass values for questionText, optionA, optionB, optionC, optionD only to the constructor.
Note: Use object initializer, anywhere, when you feel a need.
*/

using System;
using System.Linq;

class Question
{
	public string questionText;
	public string optionA;
	public string optionB;
	public string optionC;
	public string optionD;
	public char correctAnswerLetter;
	private static char defaultCorrectAnswerLetter = 'X';

	public Question()
	{
		//TO DO: Initialize questionText, optionA, optionB, optionC, optionD as null. Initialize correctAnswerLetter to the value of static field 'defaultCorrectAnswerLetter'.
		correctAnswerLetter = defaultCorrectAnswerLetter;
	}

	public Question(string questionText)
	{
		//TO DO: Initialize questionText. Also, initialize optionA, optionB, optionC, optionD as null. Initialize correctAnswerLetter to the value of static field 'defaultCorrectAnswerLetter'.
		this.questionText = questionText;
		correctAnswerLetter = defaultCorrectAnswerLetter;
	}

	public Question(string questionText, string optionA, string optionB, string optionC, string optionD, char correctAnswerLetter)
	{
		//TO DO: Initialize questionText, optionA, optionB, optionC, optionD and correctAnswerText. Validate the value of correctAnswerLetter. It should either 'A', 'B', 'C' or 'D' only
		this.questionText = questionText;
		this.optionA = optionA;
		this.optionB = optionB;
		this.optionC = optionC;
		this.optionD = optionD;
		this.correctAnswerLetter = correctAnswerLetter;
	}

	public bool ValidateValueOfCorrectAnswerLetter() //out char correctAnswerLetterOut)
	{
		if (correctAnswerLetter == 'A' || correctAnswerLetter == 'B' || correctAnswerLetter == 'C' || correctAnswerLetter == 'D')
		{
			//correctAnswerLetterOut = this.correctAnswerLetter;
			return true;
		}
		else
		{
			//correctAnswerLetterOut = null;
			return false;
		}

		/* ovo je ispravno 
		if (correctAnswerLetter == 'A' || correctAnswerLetter == 'B' || correctAnswerLetter == 'C' || correctAnswerLetter == 'D') //validating correctAnswerLetter parameter
            this.correctAnswerLetter = correctAnswerLetter;
        else
            this.correctAnswerLetter = Question.defaultCorrectAnswerLetter; //defaultCorrectAnswerLetter is a static field
		*/

	}

	public bool AreOptionsValid()
	{
		//TO DO: Return true, if at least two options are not null
		byte numberOfNullOptions = 0;

		if (optionA == null)
			numberOfNullOptions++;
		if (optionB == null)
			numberOfNullOptions++;
		if (optionC == null)
			numberOfNullOptions++;
		if (optionD == null)
			numberOfNullOptions++;

		if (numberOfNullOptions > 2)
		{
			return false;
		}
		else
		{
			return true;
		}
	}
}

class Program
{
	static void Main()
	{
		string textIsAnswerCorrect = "false";
		string textCorrectAnswerIs = "";

		//1 TO DO: Create an object of Question class and pass no arguments to the constructor
		// to show quesions an object Initializer is needed !
		Question q1 = new Question() { questionText = "Question: What is the capital of the Croatia?", optionA = "Option A: Split", optionB = "Option B: Zagreb", optionC = "Option C: Dubrovnik", optionD = "Option D: Rijeka", correctAnswerLetter = 'B' };
		System.Console.WriteLine("\n***Question 1***");

		if (q1.AreOptionsValid())
		{
			System.Console.WriteLine(q1.questionText);
			System.Console.WriteLine(q1.optionA);
			System.Console.WriteLine(q1.optionB);
			System.Console.WriteLine(q1.optionC);
			System.Console.WriteLine(q1.optionD);

			System.Console.Write("Answer:");
			string answer = System.Console.ReadLine().Trim();

			//string textIsAnswerCorrect = "false";
			if (char.Parse(answer.ToUpper()) == q1.correctAnswerLetter)
			{
				textIsAnswerCorrect = "true";
			}
			else
			{
				textCorrectAnswerIs = "Correct answer is " + q1.correctAnswerLetter + "!";
			}

			System.Console.WriteLine("The answer is " + textIsAnswerCorrect + "!");
			System.Console.WriteLine(textCorrectAnswerIs);

		}
		else
		{
			System.Console.WriteLine("Options for this question are not valid!");
		}


		//2 TO DO: Create an object of Question class and pass value for questionText only to the constructor.
		Question q2 = new Question("Question: What is the capital of the France?");
		System.Console.WriteLine("\n***Question 2***");
		if (q2.AreOptionsValid())
		{
			System.Console.WriteLine(q2.questionText);
			System.Console.WriteLine(q2.optionA);
			System.Console.WriteLine(q2.optionB);
			System.Console.WriteLine(q2.optionC);
			System.Console.WriteLine(q2.optionD);

			System.Console.Write("Answer:");
			string answer = System.Console.ReadLine();

			//string textIsAnswerCorrect = "false";
			if (answer.ToUpper() == q2.correctAnswerLetter.ToString())
			{
				textIsAnswerCorrect = "true";
				//textCorrectAnswerIs = "Correct answer is " + q2.correctAnswerLetter;
			}
			//System.Console.WriteLine("The answer is " + textIsAnswerCorrect + "!");
			//System.Console.Write("\n" + textCorrectAnswerIs);

		}
		else
		{
			System.Console.WriteLine("Options for this question are not valid!");
		}


		//3 TO DO: Create an object of Question class and pass values for questionText, optionA, optionB, optionC, optionD and correctAnswerLetter to the constructor.
		//Question q3 = new Question() {questionText="Question: What is the capital of the USA?", optionA= "Option A: London", optionB= "Option B: New York", optionC= "Option C: Washington, D.C.", optionD= "Option D: San Diego", correctAnswerLetter= 'C' };
		Question q3 = new Question("Question: What is the capital of the USA?", "Option A: London", "Option B: New York", "Option C: Washington, D.C.", "Option D: San Diego", 'C');

		System.Console.WriteLine("\n***Question 3***");

		if (q3.AreOptionsValid())
		{
			System.Console.WriteLine(q3.questionText);
			System.Console.WriteLine(q3.optionA);
			System.Console.WriteLine(q3.optionB);
			System.Console.WriteLine(q3.optionC);
			System.Console.WriteLine(q3.optionD);

			System.Console.Write("Answer:");
			string answer = System.Console.ReadLine().Trim();

			//string textIsAnswerCorrect = "false";
			if (char.Parse(answer.ToUpper()) == q3.correctAnswerLetter)
			{
				textIsAnswerCorrect = "true";
			}
			else
			{
				textCorrectAnswerIs = "Correct answer is " + q3.correctAnswerLetter + "!";
			}

			System.Console.WriteLine("The answer is " + textIsAnswerCorrect + "!");
			System.Console.WriteLine(textCorrectAnswerIs);

		}
		else
		{
			System.Console.WriteLine("Options for this question are not valid!");
		}



		//4 TO DO: Create an object of Question class and pass values for questionText, optionA, optionB, optionC, optionD only to the constructor.
		// there is no cunstructor for passing that parameters so I used Object Initializer
		Question q4 = new Question("Question: What is the capital of the Spain?") { optionA = "Option A: Barcelona", optionB = "Option B: Malaga", optionC = "Option C: Ronda", optionD = "Option D: Madrid" };
		System.Console.WriteLine("\n***Question 4***");

		if (q4.correctAnswerLetter == 'X')
		{
			System.Console.WriteLine("Correct answer letter is unknown!");
		}



		System.Console.ReadKey();
	}
}
