using Microsoft.VisualBasic;

namespace Enums
{
	internal class Program
	{
		static void Main(string[] args)
		{

            //Console.Write("Enter week day number:");
            //int.TryParse(Console.ReadLine(), out int weekday);

            #region GetName

            //Console.WriteLine(Enum.GetName(typeof(WeekDays), weekday));

            #endregion

            #region GetNames

            //string[] weekdays = Enum.GetNames(typeof(WeekDays));

            //foreach (var item in weekdays)
            //{
            //             Console.WriteLine(item);
            //}

            #endregion

            #region GetValues
            //Array values = Enum.GetValues(typeof(WeekDays));
            //foreach (var value in values)
            //{

            //	Console.WriteLine((int)value);
            //}

            #endregion

            #region isDefined

            // Console.WriteLine(Enum.IsDefined(typeof(WeekDays), "monday"));


            #endregion
            //         switch (weekday)
            //{
            //	case 1:
            //		Console.WriteLine("Monday");
            //		break;
            //	case 2:
            //		Console.WriteLine("Tuesday");
            //		break;


            //	case 7:
            //		Console.WriteLine("Sunday");
            //		break;
            //	default:
            //		Console.WriteLine("Enter valid week number");
            //		break;
            //}


            #region Task1
            //Task 1: Enum with Methods
            //Objective:
            //Create an enum with methods to convert enum values to user-friendly strings.

            //Steps:

            //Define an enum named Season.
            //Create a method that returns a description for each enum value.

            //EnumOperations enumOperations = new EnumOperations();
            //         Console.WriteLine(enumOperations.ReturnValue(5));


            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.BackgroundColor = ConsoleColor.Blue;
            //Console.WriteLine("Opening Programm");

            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine("Exiting Programm");

            //Console.WriteLine((int)DayOfWeek.Monday);

            //StringSplitOptions

            //string text = "fasf,has, ks,,ku";


            //string[] textpieces = text.Split(',',StringSplitOptions.RemoveEmptyEntries);

            //foreach (string piece in textpieces)
            //{
            //             Console.WriteLine(piece);
            //         }

            #endregion

            //Person person = new Person();


    //        Console.Write("Enter season name:");
    //        //string seasonName = Console.ReadLine();
    //        Enum.TryParse(typeof(Seasons), Console.ReadLine(), true, out object season);
    //        if (season is not null)
				//Console.WriteLine((Seasons)season);



		}
	}
}
