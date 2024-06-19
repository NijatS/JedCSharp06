using Customization.Extensions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Customization
{
	internal class Program
	{
		static void Main(string[] args)
		{

			//try
			//{

			//	Console.WriteLine("Enter Person Name");
			//	string name = Console.ReadLine();

			//	Console.WriteLine("Surname:");
			//	string surname = Console.ReadLine();

			//	Console.WriteLine("Age:");
			//	int age = int.Parse(Console.ReadLine());


			//	Person person = new Person(name, surname, age);
			//}
			//catch (Exception ex)
			//{

			//	Console.WriteLine(ex.Message);
			//}

			//Task 7: Create a custom exception InvalidAgeException that is thrown when an invalid age(less than 0 or greater than 120) is provided.

			//try
			//{
			//	string name = "nijat";

			//	double result = SquareofRoot(-25);
			//   Console.WriteLine(result);
			//         }
			//catch (InvalidMathOperationException ex)
			//{
			//	Console.WriteLine(ex.Message);
			//}

			//         Console.WriteLine("isledi");




			int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };


			int result = numbers.SumEvenNumbers();
			//Console.WriteLine(result);


			//Task 1: Integer Extension Method
			//Create an extension method IsEven for the int class that returns true if the integer is even, and false otherwise.


			//int a = 6;
			//         Console.WriteLine(a.isEven());

			string s = "salam";
			Console.WriteLine(s.Reverse());

			//Task 2: String Reverse
			//Create an extension method Reverse for the string class that returns the string reversed.

			//Task 3: DateTime Extension Method
			//Create an extension method IsWeekend for the DateTime class that returns true if the date is a Saturday or Sunday, and false otherwise.

			DateTime dt = DateTime.Now.AddDays(3);
			Console.WriteLine(dt.IsWeekend());

			//Task 4: Integer Factorial
			//Create an extension method Factorial for the int class that returns the factorial of the integer.
			int a = -2;

			try
			{
				Console.WriteLine(a.Factorial());
			}
			catch(InvalidMathOperationException ex)
			{
                Console.WriteLine(ex.Message);
            }


        }

		public static double SquareofRoot(double num)
		{
			if (num < 0)
				throw new InvalidMathOperationException("Kokalti menfi ola bilmez");


			return Math.Sqrt(num);
		}
	}
}
